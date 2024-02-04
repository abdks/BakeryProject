using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Teams
{
    public class RemoveTeamsCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTeamsCommand(int id)
        {
            Id = id;
        }
    }
}
