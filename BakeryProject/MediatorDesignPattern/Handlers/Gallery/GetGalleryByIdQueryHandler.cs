using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Gallery;
using BakeryProject.MediatorDesignPattern.Queries.HelpSupport;
using BakeryProject.MediatorDesignPattern.Results.Gallery;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Gallery
{
    public class GetGalleryByIdQueryHandler : IRequestHandler<GetGalleryByIdQuery, GetGalleryByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetGalleryByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetGalleryByIdQueryResult> Handle(GetGalleryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.Galleries.FindAsync(request.Id);
            return new GetGalleryByIdQueryResult
            {
               GalleryId = values.GalleryId,
               Image = values.Image
            };
        }
    }
}
