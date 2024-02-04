using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using BakeryProject.MediatorDesignPattern.Commands.Teams;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Teams
{
    public class CreateTeamsCommandHandler : IRequestHandler<CreateTeamsCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateTeamsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateTeamsCommand request, CancellationToken cancellationToken)
        {
            _saleContext.Teams.Add(new DAL.Entities.Teams
            {
                TeamsName = request.TeamsName,
                Image = request.Image
            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
