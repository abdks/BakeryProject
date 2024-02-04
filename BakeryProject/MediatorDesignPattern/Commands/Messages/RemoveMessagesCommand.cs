using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Messages
{
    public class RemoveMessagesCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMessagesCommand(int id)
        {
            Id = id;
        }
    }
}
