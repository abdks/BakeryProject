using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Gallery
{
    public class RemoveGalleryCommand  :IRequest
    {
        public int Id { get; set; }

        public RemoveGalleryCommand(int id)
        {
            Id = id;
        }
    }
}
