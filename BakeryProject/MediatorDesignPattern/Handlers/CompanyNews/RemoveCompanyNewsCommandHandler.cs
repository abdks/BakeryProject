using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.CompanyNews
{
    public class RemoveCompanyNewsCommandHandler : IRequestHandler<RemoveCompanyNewsCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveCompanyNewsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveCompanyNewsCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Companynews.Find(request.Id);
            _saleContext.Companynews.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
