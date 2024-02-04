using BakeryProject.MediatorDesignPattern.Results.Messages;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Messages
{
    public class GetMessagesByIdQuery : IRequest<GetMessagesByIdQueryResult>
    {
        public int Id { get; set; }

        public GetMessagesByIdQuery(int id)
        {
            Id = id;
        }
    }
}
