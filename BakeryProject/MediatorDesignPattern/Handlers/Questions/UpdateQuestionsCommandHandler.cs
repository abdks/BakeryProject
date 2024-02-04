using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Questions
{
    public class UpdateQuestionsCommandHandler : IRequestHandler<UpdateQuestionsCommand>
    {
        private readonly SaleContext _saleContext;

        public UpdateQuestionsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(UpdateQuestionsCommand request, CancellationToken cancellationToken)
        {
            var values = _saleContext.Questions.Find(request.QuestionsID);
            values.Question = request.Question;
            values.Answer = request.Answer;
            await _saleContext.SaveChangesAsync();
        }
    }
}
