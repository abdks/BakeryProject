using BakeryProject.CQRSPattern.Commands.OnePage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.OnePage
{
    public class UpdateOnePageCommandHandler
    {
        private readonly SaleContext _saleContext;
        public UpdateOnePageCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateOnePageCommand command)
        {
            var values = _saleContext.OnePages.Find(command.OnePageID);
          values.Title = command.Title;
            values.Image = command.Image;
            values.Description1 = command.Description1;
            values.Description2 = command.Description2;
            _saleContext.SaveChanges();
        }
    }
}
