using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Contact;
using BakeryProject.MediatorDesignPattern.Queries.Gallery;
using BakeryProject.MediatorDesignPattern.Results.Contact;
using BakeryProject.MediatorDesignPattern.Results.Gallery;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.Contact
{
    public class GetAllContactQueryHandler : IRequestHandler<GetAllContactQuery, List<GetAllContactQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllContactQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllContactQueryResult>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.contacts.Select(x => new GetAllContactQueryResult
            {
               ContactID = x.ContactID,
               No = x.No,
               Adress = x.Adress,
               Mail = x.Mail,
            }).ToListAsync();
        }
    }
}
