using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Gallery
{
    public class CreateGalleryCommand : IRequest
    {
       
        public string Image { get; set; }
    }
}
