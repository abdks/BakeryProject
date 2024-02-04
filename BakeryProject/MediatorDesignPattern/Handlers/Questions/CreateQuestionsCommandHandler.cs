using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using MediatR;

namespace BakeryProject.MediatorDesignPattern.Handlers.Questions
{
    public class CreateQuestionsCommandHandler : IRequestHandler<CreateQuestionsCommand>
    {
        private readonly SaleContext _saleContext;

        public CreateQuestionsCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task Handle(CreateQuestionsCommand request, CancellationToken cancellationToken)
        {
            _saleContext.Questions.Add(new DAL.Entities.Questions
            {
                Question = request.Question,
                Answer = request.Answer
            });
            await _saleContext.SaveChangesAsync();
        }
    }
}
