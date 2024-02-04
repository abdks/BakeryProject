using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Contact
{
    public class RemoveContactCommand : IRequest
    { 
        public int Id { get; set; }

        public RemoveContactCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
