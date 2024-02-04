using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Queries.Teams;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using BakeryProject.MediatorDesignPattern.Results.Teams;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Teams
{
    public class GetTeamsByIdQueryHandler : IRequestHandler<GetTeamsByIdQuery, GetTeamsByIdQueryResult>

    {
        private readonly SaleContext _saleContext;

        public GetTeamsByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetTeamsByIdQueryResult> Handle(GetTeamsByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.Teams.FindAsync(request.Id);
            return new GetTeamsByIdQueryResult
            {
                TeamsID = values.TeamsID,
                TeamsName = values.TeamsName,
                Image = values.Image
            };
        }
    }
}
