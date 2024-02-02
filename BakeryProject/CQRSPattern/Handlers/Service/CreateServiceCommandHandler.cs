using BakeryProject.CQRSPattern.Commands.Service;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Service
{
    public class CreateServiceCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateServiceCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateServiceCommand command)
        {
            _saleContext.Services.Add(new DAL.Entities.Services
            {
                Description = command.Description,
                Image = command.Image,
                Title = command.Title,
            });
            _saleContext.SaveChanges();
        }
    }
}
