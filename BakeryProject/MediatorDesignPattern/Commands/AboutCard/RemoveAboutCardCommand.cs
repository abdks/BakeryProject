using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.AboutCard
{
    public class RemoveAboutCardCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveAboutCardCommand(int id)
        {
            Id = id;
        }
    }
}
