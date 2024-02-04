namespace BakeryProject.MediatorDesignPattern.Results.Messages
{
    public class GetMessagesByIdQueryResult
    {
        public int MessagesID { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
