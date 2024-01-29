using BakeryProject.CQRSPattern.Commands;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveCategoryCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveCategoryCommand command) {
            var value = _saleContext.Categories.Find(command.Id);
            _saleContext.Categories.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
