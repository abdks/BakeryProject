using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Contact;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Contact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateContactCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            _saleContext.contacts.Add(new DAL.Entities.Contact
            {
             Adress = request.Adress,
             No = request.No,
             Mail = request.Mail
            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
