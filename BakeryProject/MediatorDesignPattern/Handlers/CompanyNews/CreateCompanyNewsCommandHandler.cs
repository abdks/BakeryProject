using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.CompanyNews
{
    public class CreateCompanyNewsCommandHandler : IRequestHandler<CreateCompanyNewsCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateCompanyNewsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateCompanyNewsCommand request, CancellationToken cancellationToken)
        {
            _saleContext.Companynews.Add(new Companynews
            {
              Date = request.Date,
              Title = request.Title,
              Image = request.Image

            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
