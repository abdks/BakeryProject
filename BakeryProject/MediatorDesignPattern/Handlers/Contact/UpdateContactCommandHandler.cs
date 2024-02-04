using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Contact;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Contact
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateContactCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.contacts.Find(request.ContactID);
            values.Adress = request.Adress;
            values.No = request.No;
            values.Mail = request.Mail;
            await _saleContext.SaveChangesAsync();
        }
    }
}
