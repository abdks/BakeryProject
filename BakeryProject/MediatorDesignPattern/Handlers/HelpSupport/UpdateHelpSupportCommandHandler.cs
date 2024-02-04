using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.HelpSupport
{
    public class UpdateHelpSupportCommandHandler : IRequestHandler<UpdateHelpSupportCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateHelpSupportCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateHelpSupportCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.HelpSupports.Find(request.HelpSupportID);
            values.HelpSupportName = request.HelpSupportName;
            values.Description = request.Description;
            values.Image = request.Image;
            await _saleContext.SaveChangesAsync();
        }
    }
}
