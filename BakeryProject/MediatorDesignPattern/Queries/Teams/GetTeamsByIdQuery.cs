using BakeryProject.MediatorDesignPattern.Results.Questions;
using BakeryProject.MediatorDesignPattern.Results.Teams;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Teams
{
    public class GetTeamsByIdQuery : IRequest<GetTeamsByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTeamsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
