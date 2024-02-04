using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.HelpSupport
{
    public class RemoveHelpSupportCommandHandler : IRequestHandler<RemoveHelpSupportCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveHelpSupportCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveHelpSupportCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.HelpSupports.Find(request.Id);
            _saleContext.HelpSupports.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
