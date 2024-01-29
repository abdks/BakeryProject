using BakeryProject.CQRSPattern.Commands;
using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;

namespace BakeryProject.CQRSPattern.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateCategoryCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateCategoryCommand command)
        {
            _saleContext.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            _saleContext.SaveChanges();
        }
    }
}
