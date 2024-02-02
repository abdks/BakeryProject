using BakeryProject.CQRSPattern.Commands.TwoPage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.TwoPage
{
    public class UpdateTwoPageCommandHandler
    {
        private readonly SaleContext _saleContext;
        public UpdateTwoPageCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateTwoPageCommand command)
        {
            var values = _saleContext.TwoPages.Find(command.TwoPageID);
            values.NameSurname = command.NameSurname;
            values.Unvan = command.Unvan;
            values.Description = command.Description;
            values.Title = command.Title;
            values.Image = command.Image;
            _saleContext.SaveChanges();
        }
    }
}
