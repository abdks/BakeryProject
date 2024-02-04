using BakeryProject.MediatorDesignPattern.Results.Questions;
using BakeryProject.MediatorDesignPattern.Results.Teams;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Teams
{
    public class GetAllTeamsQuery : IRequest<List<GetAllTeamsQueryResult>>
    {
    }
}
