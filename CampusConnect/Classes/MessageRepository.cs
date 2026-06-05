using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    /// <summary>
    /// Data Access Layer for the messaging module.
    /// All SQL lives here. No UI code.
    /// </summary>
    public class MessageRepository
    {
        // ── Conversations ────────────────────────────────────────────

        /// <summary>
        /// Returns all conversation partners for the current user, ordered
        /// by the most recent message descending.
        /// </summary>
        public List<ConversationModel> GetConversations(int myProfileID)
        {
            var list = new List<ConversationModel>();

            const string sql = @"
                SELECT
                    p.ProfileID,
                    CONCAT(p.FirstName, ' ', p.LastName) AS FullName,
                    (
                        SELECT m2.Content
                        FROM   messages m2
                        WHERE  (m2.SenderID = @me AND m2.ReceiverID = p.ProfileID)
                            OR (m2.SenderID = p.ProfileID AND m2.ReceiverID = @me)
                        ORDER  BY m2.SentAt DESC
                        LIMIT  1
                    ) AS LastMessage,
                    (
                        SELECT m3.SentAt
                        FROM   messages m3
                        WHERE  (m3.SenderID = @me AND m3.ReceiverID = p.ProfileID)
                            OR (m3.SenderID = p.ProfileID AND m3.ReceiverID = @me)
                        ORDER  BY m3.SentAt DESC
                        LIMIT  1
                    ) AS LastAt
                FROM user_profiles p
                WHERE p.ProfileID IN (
                    SELECT SenderID   FROM messages WHERE ReceiverID = @me
                    UNION
                    SELECT ReceiverID FROM messages WHERE SenderID   = @me
                )
                ORDER BY LastAt DESC";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@me", myProfileID);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new ConversationModel
                            {
                                OtherProfileID      = Convert.ToInt32(r["ProfileID"]),
                                OtherName           = r["FullName"].ToString(),
                                LastMessagePreview  = r["LastMessage"] != DBNull.Value
                                                        ? r["LastMessage"].ToString()
                                                        : "",
                                LastMessageAt       = r["LastAt"] != DBNull.Value
                                                        ? Convert.ToDateTime(r["LastAt"])
                                                        : DateTime.MinValue
                            });
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Searches conversation partners by name (filters existing conversations).
        /// </summary>
        public List<ConversationModel> SearchConversations(int myProfileID, string query)
        {
            var all = GetConversations(myProfileID);
            if (string.IsNullOrWhiteSpace(query)) return all;

            string q = query.Trim().ToLower();
            var filtered = new List<ConversationModel>();
            foreach (var c in all)
                if (c.OtherName.ToLower().Contains(q))
                    filtered.Add(c);
            return filtered;
        }

        // ── Messages ─────────────────────────────────────────────────

        /// <summary>Returns all messages between two users, oldest first.</summary>
        public List<MessageModel> GetMessages(int myProfileID, int otherProfileID)
        {
            var list = new List<MessageModel>();

            const string sql = @"
                SELECT MessageID, SenderID, ReceiverID, Content, SentAt
                FROM   messages
                WHERE  (SenderID = @me    AND ReceiverID = @other)
                    OR (SenderID = @other AND ReceiverID = @me)
                ORDER  BY SentAt ASC";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@me",    myProfileID);
                    cmd.Parameters.AddWithValue("@other", otherProfileID);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new MessageModel
                            {
                                MessageID  = Convert.ToInt32(r["MessageID"]),
                                SenderID   = Convert.ToInt32(r["SenderID"]),
                                ReceiverID = Convert.ToInt32(r["ReceiverID"]),
                                Content    = r["Content"].ToString(),
                                SentAt     = Convert.ToDateTime(r["SentAt"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>Inserts a new message. Returns the new MessageID.</summary>
        public int SendMessage(int senderID, int receiverID, string content)
        {
            const string sql = @"
                INSERT INTO messages (SenderID, ReceiverID, Content)
                VALUES (@s, @r, @c);
                SELECT LAST_INSERT_ID();";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@s", senderID);
                    cmd.Parameters.AddWithValue("@r", receiverID);
                    cmd.Parameters.AddWithValue("@c", content);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Deletes a message only if it belongs to the requesting user.
        /// Returns true if a row was deleted.
        /// </summary>
        public bool DeleteMessage(int messageID, int myProfileID)
        {
            const string sql = @"
                DELETE FROM messages
                WHERE MessageID = @id AND SenderID = @me";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", messageID);
                    cmd.Parameters.AddWithValue("@me", myProfileID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>Confirms ownership of a message before deletion.</summary>
        public bool IsMessageOwner(int messageID, int myProfileID)
        {
            const string sql =
                "SELECT COUNT(*) FROM messages WHERE MessageID = @id AND SenderID = @me";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", messageID);
                    cmd.Parameters.AddWithValue("@me", myProfileID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        // ── Users ────────────────────────────────────────────────────

        /// <summary>Resolves Session.AccountID → ProfileID.</summary>
        public int GetMyProfileID(int accountID)
        {
            const string sql =
                "SELECT ProfileID FROM user_profiles WHERE AccountID = @aid";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@aid", accountID);
                    var r = cmd.ExecuteScalar();
                    return r != null ? Convert.ToInt32(r) : -1;
                }
            }
        }

        /// <summary>
        /// Searches all users by name or username, excluding the current user.
        /// Used by the New Chat dialog.
        /// </summary>
        public List<UserModel> SearchAllUsers(int myProfileID, string query)
        {
            var list = new List<UserModel>();

            const string sql = @"
                SELECT up.ProfileID,
                       CONCAT(up.FirstName, ' ', up.LastName) AS FullName,
                       ua.Username
                FROM   user_profiles up
                INNER  JOIN user_accounts ua ON ua.AccountID = up.AccountID
                WHERE  up.ProfileID <> @me
                  AND  ua.IsActive = 1
                  AND  (
                         up.FirstName  LIKE @q
                      OR up.LastName   LIKE @q
                      OR CONCAT(up.FirstName, ' ', up.LastName) LIKE @q
                      OR ua.Username   LIKE @q
                  )
                ORDER  BY up.FirstName, up.LastName
                LIMIT  100";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@me", myProfileID);
                    cmd.Parameters.AddWithValue("@q",  "%" + query.Trim() + "%");
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new UserModel
                            {
                                ProfileID = Convert.ToInt32(r["ProfileID"]),
                                FullName  = r["FullName"].ToString(),
                                Username  = r["Username"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Returns all users except the current one (no filter).
        /// Used for the initial load of the New Chat dialog.
        /// </summary>
        public List<UserModel> GetAllUsers(int myProfileID)
        {
            return SearchAllUsers(myProfileID, "");
        }

        /// <summary>
        /// Checks whether a conversation (any message) already exists between
        /// the two profiles. Returns true if it does.
        /// </summary>
        public bool ConversationExists(int myProfileID, int otherProfileID)
        {
            const string sql = @"
                SELECT COUNT(*) FROM messages
                WHERE (SenderID = @me AND ReceiverID = @other)
                   OR (SenderID = @other AND ReceiverID = @me)";

            using (var con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@me",    myProfileID);
                    cmd.Parameters.AddWithValue("@other", otherProfileID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
    }
}
