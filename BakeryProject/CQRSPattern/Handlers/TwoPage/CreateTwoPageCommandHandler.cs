using BakeryProject.CQRSPattern.Commands.TwoPage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.TwoPage
{
    public class CreateTwoPageCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateTwoPageCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateTwoPageCommand command)
        {
            _saleContext.TwoPages.Add(new DAL.Entities.TwoPage
            {
                Image = command.Image,
                Title = command.Title,
                Description = command.Description,
                NameSurname = command.NameSurname,
                Unvan = command.Unvan
            });
            _saleContext.SaveChanges();
        }
    }
}
