using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.HelpSupport;
using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.HelpSupport
{
    public class GetHelpSupportByIdQueryHandler : IRequestHandler<GetHelpSupportByIdQuery, GetHelpSupportByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetHelpSupportByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetHelpSupportByIdQueryResult> Handle(GetHelpSupportByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.HelpSupports.FindAsync(request.Id);
            return new GetHelpSupportByIdQueryResult
            {
             HelpSupportID= values.HelpSupportID,
             HelpSupportName= values.HelpSupportName,
             Description= values.Description,
             Image = values.Image
            };
        }
    }
}
