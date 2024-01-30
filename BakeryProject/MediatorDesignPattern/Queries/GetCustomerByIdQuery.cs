using BakeryProject.MediatorDesignPattern.Results;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries
{
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
