using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.AboutCard
{
    public class UpdateAboutCardCommand : IRequest
    {
        public int AboutCardID { get; set; }
        public string AboutCardName { get; set; }
        public string AboutCardDescription { get; set; }
        public string Image { get; set; }
    }
}
