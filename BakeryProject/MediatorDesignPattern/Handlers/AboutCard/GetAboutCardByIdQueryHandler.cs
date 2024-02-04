using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.AboutCard;
using BakeryProject.MediatorDesignPattern.Queries.CompanyNews;
using BakeryProject.MediatorDesignPattern.Results.AboutCard;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.AboutCard
{
    public class GetAboutCardByIdQueryHandler : IRequestHandler<GetAboutCardByIdQuery, GetAboutCardByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetAboutCardByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetAboutCardByIdQueryResult> Handle(GetAboutCardByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.AboutCards.FindAsync(request.Id);
            return new GetAboutCardByIdQueryResult
            {
                AboutCardID= values.AboutCardID,
                AboutCardDescription= values.AboutCardDescription,
                AboutCardName= values.AboutCardName,
                Image = values.Image
            };
        }
    }
}
