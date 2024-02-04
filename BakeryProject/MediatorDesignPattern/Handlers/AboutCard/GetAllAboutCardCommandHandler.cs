using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.AboutCard;
using BakeryProject.MediatorDesignPattern.Queries.CompanyNews;
using BakeryProject.MediatorDesignPattern.Results.AboutCard;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.AboutCard
{
    public class GetAllAboutCardCommandHandler : IRequestHandler<GetAllAboutCardQuery, List<GetAllAboutCardQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllAboutCardCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllAboutCardQueryResult>> Handle(GetAllAboutCardQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.AboutCards.Select(x => new GetAllAboutCardQueryResult
            {
             AboutCardID= x.AboutCardID,
             AboutCardDescription= x.AboutCardDescription,
             AboutCardName= x.AboutCardName,
             Image = x.Image
            }).ToListAsync();
        }
    }
}
