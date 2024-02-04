using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.HelpSupport;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.HelpSupport
{
    public class GetAllHelpSupportQueryHandler : IRequestHandler<GetAllHelpSupportQuery, List<GetAllHelpSupportQueryResult>>

    {
        private readonly SaleContext _saleContext;

        public GetAllHelpSupportQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllHelpSupportQueryResult>> Handle(GetAllHelpSupportQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.HelpSupports.Select(x => new GetAllHelpSupportQueryResult
            {
                HelpSupportID= x.HelpSupportID,
                HelpSupportName= x.HelpSupportName,
                Description = x.Description,
                Image = x.Image
            }).ToListAsync();
        }
    }
}
