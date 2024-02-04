using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.HelpSupport
{
    public class CreateHelpSupportCommandHandler : IRequestHandler<CreateHelpSupportCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateHelpSupportCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateHelpSupportCommand request, CancellationToken cancellationToken)
        {
            _saleContext.HelpSupports.Add(new DAL.Entities.HelpSupport
            {
                HelpSupportName = request.HelpSupportName,
                Description = request.Description,
                Image = request.Image,
            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
