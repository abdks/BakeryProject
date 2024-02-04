using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Gallery;
using BakeryProject.MediatorDesignPattern.Queries.HelpSupport;
using BakeryProject.MediatorDesignPattern.Results.Gallery;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace BakeryProject.MediatorDesignPattern.Handlers.Gallery
{
    public class GetAllGalleryQueryHandler : IRequestHandler<GetAllGalleryQuery, List<GetAllGalleryQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllGalleryQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllGalleryQueryResult>> Handle(GetAllGalleryQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.Galleries.Select(x => new GetAllGalleryQueryResult
            {
                    GalleryId = x.GalleryId,
                    Image = x.Image
            }).ToListAsync();
        }
    }
}
