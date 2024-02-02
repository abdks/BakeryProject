using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.CompanyNews;
using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.CompanyNews
{
    public class GetCompanyNewsByIdQueryHandler : IRequestHandler<GetCompanyNewsByIdQuery, GetCompanyNewsByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetCompanyNewsByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetCompanyNewsByIdQueryResult> Handle(GetCompanyNewsByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.Companynews.FindAsync(request.Id);
            return new GetCompanyNewsByIdQueryResult
            {
                CompanynewsID= values.CompanynewsID,
                Date = values.Date,
                Image = values.Image,
                Title = values.Title
            };

        }
    }
}
