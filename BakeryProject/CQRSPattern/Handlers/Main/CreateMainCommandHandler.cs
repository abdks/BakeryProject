using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;

namespace BakeryProject.CQRSPattern.Handlers.Main
{
    public class CreateMainCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateMainCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateMainCommand command)
        {
            _saleContext.Mains.Add(new DAL.Entities.Main
            {
                Title1 = command.Title1,
                Title2 = command.Title2
            });
            _saleContext.SaveChanges();
        }
    }
}
