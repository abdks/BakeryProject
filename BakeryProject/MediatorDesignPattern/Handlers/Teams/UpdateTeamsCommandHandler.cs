using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using BakeryProject.MediatorDesignPattern.Commands.Teams;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Teams
{
    public class UpdateTeamsCommandHandler : IRequestHandler<UpdateTeamsCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateTeamsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateTeamsCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Teams.Find(request.TeamsID);
            values.TeamsName = request.TeamsName;
            values.Image = request.Image;
         
            await _saleContext.SaveChangesAsync();
        }
    }
}
