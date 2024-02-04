using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Gallery
{
    public class RemoveGalleryCommandHandler : IRequestHandler<RemoveGalleryCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveGalleryCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveGalleryCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Galleries.Find(request.Id);
            _saleContext.Galleries.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
