using BakeryProject.MediatorDesignPattern.Results.AboutCard;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.AboutCard
{
    public class GetAllAboutCardQuery : IRequest<List<GetAllAboutCardQueryResult>>
    {
    }
}
