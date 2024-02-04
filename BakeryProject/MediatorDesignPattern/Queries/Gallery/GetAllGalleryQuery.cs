using BakeryProject.MediatorDesignPattern.Results.Gallery;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Gallery
{
    public class GetAllGalleryQuery : IRequest<List<GetAllGalleryQueryResult>>
    {
    }
}
