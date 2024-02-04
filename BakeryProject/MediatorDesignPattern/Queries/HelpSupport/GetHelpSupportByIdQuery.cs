using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.HelpSupport
{
    public class GetHelpSupportByIdQuery : IRequest<GetHelpSupportByIdQueryResult>
    {
        public int Id { get; set; }

        public GetHelpSupportByIdQuery(int id)
        {
            Id = id;
        }
    }
}
