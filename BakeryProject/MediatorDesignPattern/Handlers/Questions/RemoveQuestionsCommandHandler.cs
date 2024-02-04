using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Questions
{
    public class RemoveQuestionsCommandHandler : IRequestHandler<RemoveQuestionsCommand>
    {
        private readonly SaleContext _saleContext;

        public RemoveQuestionsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(RemoveQuestionsCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Questions.Find(request.Id);
            _saleContext.Questions.Remove(values);
            await _saleContext.SaveChangesAsync();
        }
    }
}
