using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.AboutCard;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.AboutCard
{
    public class UpdateAboutCardCommandHandler : IRequestHandler<UpdateAboutCardCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateAboutCardCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateAboutCardCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.AboutCards.Find(request.AboutCardID);
        values.AboutCardName = request.AboutCardName;
            values.AboutCardDescription = request.AboutCardDescription;
            values.Image = request.Image;
            await _saleContext.SaveChangesAsync();
        }
    }
}
