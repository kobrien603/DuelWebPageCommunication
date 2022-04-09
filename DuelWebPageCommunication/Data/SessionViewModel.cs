namespace DuelWebPageCommunication.Data
{
    public class SessionViewModel
    {
        public string SessionID { get; set; } = Guid.NewGuid().ToString();
        public string Message { get; set; } = "Default Message";
    }
}
