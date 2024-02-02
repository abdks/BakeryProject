using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.CompanyNews;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.CompanyNews
{
    public class GetAllCompanyNewsQueryHandler : IRequestHandler<GetAllCompanyNewsQuery, List<GetAllCompanyNewsQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllCompanyNewsQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllCompanyNewsQueryResult>> Handle(GetAllCompanyNewsQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.Companynews.Select(x => new GetAllCompanyNewsQueryResult
            {
                CompanynewsID = x.CompanynewsID,
                Date = x.Date,
                Image = x.Image,
                Title = x.Title
            }).ToListAsync();
        }
    }
}
