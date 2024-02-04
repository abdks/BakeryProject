using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Teams
{
    public class UpdateTeamsCommand : IRequest
    {
        public int TeamsID { get; set; }
        public string TeamsName { get; set; }
        public string Image { get; set; }
    }
}
