using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Gallery
{
    public class UpdateGalleryCommand : IRequest
    {
        public int GalleryId { get; set; }
        public string Image { get; set; }
    }
}
