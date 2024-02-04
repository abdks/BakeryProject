using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Questions
{
    public class GetAllQuestionsQuery: IRequest<List<GetAllQuestionsQueryResult>>
    {
    }
}
