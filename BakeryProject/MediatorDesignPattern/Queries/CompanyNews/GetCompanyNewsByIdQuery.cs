using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.CompanyNews
{
    public class GetCompanyNewsByIdQuery :IRequest<GetCompanyNewsByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCompanyNewsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
