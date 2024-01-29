using BakeryProject.CQRSPattern.Commands;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly SaleContext _saleContext;

        public UpdateCategoryCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateCategoryCommand command)
        {
            var values = _saleContext.Categories.Find(command.CategoryID);
            values.CategoryName = command.CategoryName;
            _saleContext.SaveChanges();
        }
    }
}
