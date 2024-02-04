using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.HelpSupport
{
    public class CreateHelpSupportCommand : IRequest
    {
     
        public string HelpSupportName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
