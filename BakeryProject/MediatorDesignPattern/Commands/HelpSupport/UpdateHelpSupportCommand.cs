using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.HelpSupport
{
    public class UpdateHelpSupportCommand : IRequest
    {
        public int HelpSupportID { get; set; }
        public string HelpSupportName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
