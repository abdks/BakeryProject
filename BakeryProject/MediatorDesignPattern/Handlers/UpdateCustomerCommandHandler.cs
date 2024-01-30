using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;
using System.Security.Cryptography.Pkcs;

namespace BakeryProject.MediatorDesignPattern.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateCustomerCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Customers.Find(request.CustomerID);
            values.Surname = request.Surname;
            values.Department = request.Department;
            values.Name = request.Name;
            await _saleContext.SaveChangesAsync();
        }
    }
}
