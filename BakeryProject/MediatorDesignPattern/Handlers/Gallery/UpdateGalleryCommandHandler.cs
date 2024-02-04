using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Gallery
{
    public class UpdateGalleryCommandHandler : IRequestHandler<UpdateGalleryCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateGalleryCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateGalleryCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Galleries.Find(request.GalleryId);
            values.Image = request.Image;
            await _saleContext.SaveChangesAsync();
        }
    }
}
