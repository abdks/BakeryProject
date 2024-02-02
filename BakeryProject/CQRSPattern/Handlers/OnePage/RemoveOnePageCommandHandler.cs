using BakeryProject.CQRSPattern.Commands.OnePage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.OnePage
{
    public class RemoveOnePageCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveOnePageCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveOnePageCommand command)
        {
            var value = _saleContext.OnePages.Find(command.Id);
            _saleContext.OnePages.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
