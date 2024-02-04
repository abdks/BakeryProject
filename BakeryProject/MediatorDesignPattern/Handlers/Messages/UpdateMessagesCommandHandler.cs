using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Messages;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Messages
{
    public class UpdateMessagesCommandHandler : IRequestHandler<UpdateMessagesCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateMessagesCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateMessagesCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Messages.Find(request.MessagesID);
            values.Message = request.Message;
            values.Subject = request.Subject;
            values.Email = request.Email;
            values.Name = request.Name;
            await _saleContext.SaveChangesAsync();
        }
    }
}
