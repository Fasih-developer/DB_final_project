using System;
using System.Collections.Generic;

namespace CampusConnect.Forms
{
    /// <summary>
    /// Service layer for messaging.
    /// Enforces business rules and delegates persistence to MessageRepository.
    /// No UI code here.
    /// </summary>
    public class MessageService
    {
        private readonly MessageRepository _repo;

        public MessageService()
        {
            _repo = new MessageRepository();
        }

        // ── Session ──────────────────────────────────────────────────

        /// <summary>Resolves the logged-in user's ProfileID from their AccountID.</summary>
        public int GetMyProfileID(int accountID)
        {
            int pid = _repo.GetMyProfileID(accountID);
            if (pid < 0)
                throw new InvalidOperationException(
                    "Your profile could not be found. Please log in again.");
            return pid;
        }

        // ── Conversations ────────────────────────────────────────────

        public List<ConversationModel> GetConversations(int myProfileID)
            => _repo.GetConversations(myProfileID);

        public List<ConversationModel> SearchConversations(int myProfileID, string query)
            => _repo.SearchConversations(myProfileID, query);

        // ── Messages ─────────────────────────────────────────────────

        public List<MessageModel> GetMessages(int myProfileID, int otherProfileID)
            => _repo.GetMessages(myProfileID, otherProfileID);

        /// <summary>
        /// Validates and sends a message.
        /// Throws ArgumentException for empty content or self-chat.
        /// </summary>
        public void SendMessage(int senderID, int receiverID, string content)
        {
            if (senderID == receiverID)
                throw new ArgumentException("You cannot send a message to yourself.");

            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Message cannot be empty.");

            _repo.SendMessage(senderID, receiverID, content.Trim());
        }

        /// <summary>
        /// Deletes a message after confirming ownership.
        /// Throws UnauthorizedAccessException if the user does not own the message.
        /// Returns true if deletion succeeded.
        /// </summary>
        public bool DeleteMessage(int messageID, int myProfileID)
        {
            if (!_repo.IsMessageOwner(messageID, myProfileID))
                throw new UnauthorizedAccessException(
                    "You can only delete your own messages.");

            return _repo.DeleteMessage(messageID, myProfileID);
        }

        // ── Users / New Chat ─────────────────────────────────────────

        public List<UserModel> GetAllUsers(int myProfileID)
            => _repo.GetAllUsers(myProfileID);

        public List<UserModel> SearchAllUsers(int myProfileID, string query)
            => _repo.SearchAllUsers(myProfileID, query);

        /// <summary>
        /// Returns true if a conversation already exists between the two users.
        /// Used to prevent duplicate conversation creation.
        /// </summary>
        public bool ConversationExists(int myProfileID, int otherProfileID)
            => _repo.ConversationExists(myProfileID, otherProfileID);
    }
}
