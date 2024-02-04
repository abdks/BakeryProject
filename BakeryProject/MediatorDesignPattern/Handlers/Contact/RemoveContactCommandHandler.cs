using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Contact;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using MediatR;
using Microsoft.VisualBasic;

namespace BakeryProject.MediatorDesignPattern.Handlers.Contact
{
    public class RemoveContactCommandHandler : IRequestHandler<RemoveContactCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveContactCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.contacts.Find(request.Id);
            _saleContext.contacts.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
