using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Gallery
{
    public class CreateGalleryCommandHandler : IRequestHandler<CreateGalleryCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateGalleryCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateGalleryCommand request, CancellationToken cancellationToken)
        {
            _saleContext.Galleries.Add(new DAL.Entities.Gallery
            {
              Image = request.Image
            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
