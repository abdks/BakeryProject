using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.CompanyNews
{
    public class GetAllCompanyNewsQuery : IRequest<List<GetAllCompanyNewsQueryResult>>
    {
    }
}
