using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;
using BakeryProject.MediatorDesignPattern.Commands;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateCustomerCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            _saleContext.Customers.Add(new Customer
            {
                Department = request.Department,
                Name = request.Name,
                Surname = request.Surname
            });
            await _saleContext.SaveChangesAsync();
        }

    }
}
