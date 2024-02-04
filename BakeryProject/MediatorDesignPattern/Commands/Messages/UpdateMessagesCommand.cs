using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Messages
{
    public class UpdateMessagesCommand : IRequest
    {
        public int MessagesID { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
