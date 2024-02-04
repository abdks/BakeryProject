using BakeryProject.MediatorDesignPattern.Results.Messages;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Messages
{
    public class GetAllMessagesQuery : IRequest<List<GetAllMessagesQueryResult>>
    {
    }
}
