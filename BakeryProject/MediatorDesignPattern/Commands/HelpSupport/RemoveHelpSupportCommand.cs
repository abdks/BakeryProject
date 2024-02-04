using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.HelpSupport
{
    public class RemoveHelpSupportCommand : IRequest

    {
        public int Id { get; set; }

        public RemoveHelpSupportCommand(int id)
        {
            Id = id;
        }
    }
}
