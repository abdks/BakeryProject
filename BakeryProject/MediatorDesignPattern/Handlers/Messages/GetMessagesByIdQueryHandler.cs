using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Messages;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Results.Messages;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Messages
{
    public class GetMessagesByIdQueryHandler : IRequestHandler<GetMessagesByIdQuery, GetMessagesByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetMessagesByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetMessagesByIdQueryResult> Handle(GetMessagesByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.Messages.FindAsync(request.Id);
            return new GetMessagesByIdQueryResult
            {
                MessagesID = values.MessagesID,
                Message = values.Message,
                Email = values.Email,
                Name = values.Name,
                Subject = values.Subject,
            };
        }
    }
}
