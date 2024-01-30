using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace BakeryProject.MediatorDesignPattern.Handlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetCustomerByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.Customers.FindAsync(request.Id);
            return new GetCustomerByIdQueryResult
            {
                CustomerID = values.CustomerID,
                Department = values.Department,
                Name = values.Name,
                Surname = values.Surname
            };

        }
    }
}
