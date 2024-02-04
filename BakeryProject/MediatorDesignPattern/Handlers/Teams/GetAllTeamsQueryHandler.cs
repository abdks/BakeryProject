using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Queries.Teams;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using BakeryProject.MediatorDesignPattern.Results.Teams;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.Teams
{
    public class GetAllTeamsQueryHandler : IRequestHandler<GetAllTeamsQuery, List<GetAllTeamsQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllTeamsQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllTeamsQueryResult>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.Teams.Select(x => new GetAllTeamsQueryResult
            {
              TeamsID= x.TeamsID,   
              TeamsName= x.TeamsName,
              Image = x.Image
            }).ToListAsync();
        }
    }
}
