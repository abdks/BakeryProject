using BakeryProject.MediatorDesignPattern.Results;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries
{
    public class GetAllCustomerQuery:IRequest<List<GetAllCustomersQueryResult>>
    {
    }
}
