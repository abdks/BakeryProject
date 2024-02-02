using BakeryProject.CQRSPattern.Commands.TwoPage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.TwoPage
{
    public class RemoveTwoPageCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveTwoPageCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveTwoPageCommand command)
        {
            var value = _saleContext.TwoPages.Find(command.Id);
            _saleContext.TwoPages.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
