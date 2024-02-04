using BakeryProject.MediatorDesignPattern.Results.AboutCard;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.AboutCard
{
    public class GetAboutCardByIdQuery : IRequest<GetAboutCardByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAboutCardByIdQuery(int id)
        {
            Id = id;
        }
    }
}
