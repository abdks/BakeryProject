using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using BakeryProject.MediatorDesignPattern.Commands.Teams;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Teams
{
    public class RemoveTeamsCommandHandler : IRequestHandler<RemoveTeamsCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveTeamsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveTeamsCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Teams.Find(request.Id);
            _saleContext.Teams.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
