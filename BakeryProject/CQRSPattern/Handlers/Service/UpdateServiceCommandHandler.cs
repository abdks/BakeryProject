using BakeryProject.CQRSPattern.Commands.Service;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Service
{
    public class UpdateServiceCommandHandler
    {
        private readonly SaleContext _saleContext;
        public UpdateServiceCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateServiceCommand command)
        {
            var values = _saleContext.Services.Find(command.ServicesID);
            values.Image= command.Image;
            values.Title= command.Title;
            values.Description= command.Description;
            
            _saleContext.SaveChanges();
        }
    }
}
