using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Contact;
using BakeryProject.MediatorDesignPattern.Queries.Gallery;
using BakeryProject.MediatorDesignPattern.Results.Contact;
using BakeryProject.MediatorDesignPattern.Results.Gallery;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Contact
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetContactByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.contacts.FindAsync(request.Id);
            return new GetContactByIdQueryResult
            {
                ContactID = values.ContactID,
                Adress = values.Adress,
                No = values.No,
                Mail = values.Mail
            };
        }
    }
}
