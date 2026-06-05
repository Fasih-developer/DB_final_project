using System;

namespace CampusConnect.Forms
{
    /// <summary>Represents one row from the messages table.</summary>
    public class MessageModel
    {
        public int      MessageID  { get; set; }
        public int      SenderID   { get; set; }   // user_profiles.ProfileID
        public int      ReceiverID { get; set; }   // user_profiles.ProfileID
        public string   Content    { get; set; }
        public DateTime SentAt     { get; set; }

        /// <summary>True when this message was sent by the currently logged-in user.</summary>
        public bool IsMine(int myProfileID) => SenderID == myProfileID;
    }
}
