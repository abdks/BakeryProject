using BakeryProject.CQRSPattern.Commands.OnePage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.OnePage
{
    public class CreateOnePageCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateOnePageCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateOnePageCommand command)
        {
            _saleContext.OnePages.Add(new DAL.Entities.OnePage
            {
               Image = command.Image,
               Title = command.Title,
               Description1 = command.Description1,
               Description2 = command.Description2,
            });
            _saleContext.SaveChanges();
        }
    }
}
