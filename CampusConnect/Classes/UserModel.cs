namespace CampusConnect.Forms
{
    /// <summary>Lightweight user record used in the New Chat user-picker dialog.</summary>
    public class UserModel
    {
        public int    ProfileID { get; set; }
        public string FullName  { get; set; }
        public string Username  { get; set; }

        public override string ToString() => FullName;
    }
}
