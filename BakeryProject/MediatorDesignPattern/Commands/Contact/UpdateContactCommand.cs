using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Contact
{
    public class UpdateContactCommand : IRequest
    {
        public int ContactID { get; set; }
        public string Adress { get; set; }
        public string No { get; set; }
        public string Mail { get; set; }
    }
}
