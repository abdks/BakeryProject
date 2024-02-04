using BakeryProject.MediatorDesignPattern.Results.Gallery;
using BakeryProject.MediatorDesignPattern.Results.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Gallery
{
    public class GetGalleryByIdQuery : IRequest<GetGalleryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGalleryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
