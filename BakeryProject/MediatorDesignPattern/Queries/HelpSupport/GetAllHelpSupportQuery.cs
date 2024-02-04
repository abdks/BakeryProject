using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.HelpSupport
{
    public class GetAllHelpSupportQuery : IRequest<List<GetAllHelpSupportQueryResult>>
    {
    }
}
