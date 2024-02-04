using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Teams
{
    public class CreateTeamsCommand : IRequest
    {
        public string TeamsName { get; set; }
        public string Image { get; set; }
    }
}
