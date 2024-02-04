using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using MediatR;
using System.Threading.Tasks;

namespace BakeryProject.MediatorDesignPattern.Handlers.CompanyNews
{
    public class UpdateCompanyNewsCommandHandler : IRequestHandler<UpdateCompanyNewsCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateCompanyNewsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateCompanyNewsCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Companynews.Find(request.CompanynewsID);
            values.Image = request.Image;
            values.Title = request.Title;
            values.Date = request.Date;
            await _saleContext.SaveChangesAsync();
        }

    }
}
