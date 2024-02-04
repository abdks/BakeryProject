using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Contact
{
    public class CreateContactCommand : IRequest
    {
        public string Adress { get; set; }
        public string No { get; set; }
        public string Mail { get; set; }
    }
}
