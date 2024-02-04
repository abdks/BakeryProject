using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries.Messages;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Results.Messages;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.Messages
{
    public class GetAllMessagesQueryHandler : IRequestHandler<GetAllMessagesQuery, List<GetAllMessagesQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllMessagesQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllMessagesQueryResult>> Handle(GetAllMessagesQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.Messages.Select(x => new GetAllMessagesQueryResult
            {
                MessagesID = x.MessagesID,
                Subject = x.Subject,
                Email = x.Email,
                Message = x.Message,
                Name = x.Name
            }).ToListAsync();
        }
    }
}
