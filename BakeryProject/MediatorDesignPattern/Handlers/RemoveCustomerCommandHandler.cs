using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveCustomerCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Customers.Find(request.Id);
            _saleContext.Customers.Remove(values);
            await _saleContext.SaveChangesAsync();
        }


    }
}
