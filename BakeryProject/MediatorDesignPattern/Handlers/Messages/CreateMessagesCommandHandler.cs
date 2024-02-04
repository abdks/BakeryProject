using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using BakeryProject.MediatorDesignPattern.Commands.Messages;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Messages
{
    public class CreateMessagesCommandHandler : IRequestHandler<CreateMessagesCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateMessagesCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateMessagesCommand request, CancellationToken cancellationToken)
        {
            _saleContext.Messages.Add(new DAL.Entities.Messages
            {
                Message = request.Message,
                Email = request.Email,
                Name = request.Name,
                Subject = request.Subject
            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
