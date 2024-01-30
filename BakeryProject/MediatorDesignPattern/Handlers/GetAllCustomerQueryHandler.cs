using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Pkcs;

namespace BakeryProject.MediatorDesignPattern.Handlers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustomersQueryResult>>
    {
        private SaleContext _saleContext;

        public GetAllCustomerQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllCustomersQueryResult>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.Customers.Select(x => new GetAllCustomersQueryResult
            {
                CustomerID = x.CustomerID,
                Department = x.Department,
                Name = x.Name,
                Surname = x.Surname
            }).ToListAsync();

        }
    }
}
