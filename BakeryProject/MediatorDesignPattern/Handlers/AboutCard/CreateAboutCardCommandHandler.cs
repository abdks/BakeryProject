using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;
using BakeryProject.MediatorDesignPattern.Commands.AboutCard;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.AboutCard
{
    public class CreateAboutCardCommandHandler : IRequestHandler<CreateAboutCardCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateAboutCardCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateAboutCardCommand request, CancellationToken cancellationToken)
        {
            _saleContext.AboutCards.Add(new DAL.Entities.AboutCard
            {
                AboutCardDescription = request.AboutCardName,
                AboutCardName = request.AboutCardName,
                Image = request.Image

            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
