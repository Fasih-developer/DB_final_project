using System;

namespace CampusConnect.Forms
{
    /// <summary>
    /// Represents a conversation between the current user and one other user.
    /// This is derived from the messages table — there is no conversations table.
    /// </summary>
    public class ConversationModel
    {
        public int      OtherProfileID   { get; set; }
        public string   OtherName        { get; set; }
        public string   LastMessagePreview { get; set; }
        public DateTime LastMessageAt    { get; set; }

        public string LastMessageTimeDisplay =>
            LastMessageAt.Date == DateTime.Today
                ? LastMessageAt.ToString("HH:mm")
                : LastMessageAt.ToString("dd MMM");
    }
}
