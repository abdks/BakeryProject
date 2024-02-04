using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.AboutCard;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.AboutCard
{
    public class RemoveAboutCardCommandHandler : IRequestHandler<RemoveAboutCardCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveAboutCardCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveAboutCardCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.AboutCards.Find(request.Id);
            _saleContext.AboutCards.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
