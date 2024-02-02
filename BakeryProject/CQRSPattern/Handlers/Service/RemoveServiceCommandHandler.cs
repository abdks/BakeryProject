using BakeryProject.CQRSPattern.Commands.Service;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Service
{
    public class RemoveServiceCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveServiceCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveServiceCommand command)
        {
            var value = _saleContext.Services.Find(command.Id);
            _saleContext.Services.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
