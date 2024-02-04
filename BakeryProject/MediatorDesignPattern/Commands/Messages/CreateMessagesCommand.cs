using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Messages
{
    public class CreateMessagesCommand : IRequest
    {
       
        public string Message { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
