using BakeryProject.MediatorDesignPattern.Results.Contact;
using BakeryProject.MediatorDesignPattern.Results.Gallery;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Queries.Contact
{
    public class GetAllContactQuery : IRequest<List<GetAllContactQueryResult>>
    {
    }
}
