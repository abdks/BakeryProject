using BakeryProject.MediatorDesignPattern.Results.Contact;
using BakeryProject.MediatorDesignPattern.Results.Gallery;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Contact
{
    public class GetContactByIdQuery : IRequest<GetContactByIdQueryResult>
    {
        public int Id { get; set; }

        public GetContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}
