using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Messages;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Messages
{
    public class RemoveMessagesCommandHandler : IRequestHandler<RemoveMessagesCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveMessagesCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveMessagesCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Messages.Find(request.Id);
            _saleContext.Messages.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
