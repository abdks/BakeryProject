using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.AboutCard
{
    public class CreateAboutCardCommand : IRequest
    {
       
        public string AboutCardName { get; set; }
        public string AboutCardDescription { get; set; }
        public string Image { get; set; }
    }
}
