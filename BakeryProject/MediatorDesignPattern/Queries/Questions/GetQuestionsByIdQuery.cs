using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Questions
{
    public class GetQuestionsByIdQuery : IRequest<GetQuestionsByIdQueryResult>
    {
        public int Id { get; set; }

        public GetQuestionsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
