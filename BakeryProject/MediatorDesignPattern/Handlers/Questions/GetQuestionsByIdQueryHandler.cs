using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;
using Microsoft.AspNetCore.Mvc.Localization;

namespace BakeryProject.MediatorDesignPattern.Handlers.Questions
{
    public class GetQuestionsByIdQueryHandler : IRequestHandler<GetQuestionsByIdQuery, GetQuestionsByIdQueryResult>
    {
        private readonly SaleContext _saleContext;

        public GetQuestionsByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<GetQuestionsByIdQueryResult> Handle(GetQuestionsByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _saleContext.Questions.FindAsync(request.Id);
            return new GetQuestionsByIdQueryResult
            {
               QuestionsID= values.QuestionsID,
               Question = values.Question,
               Answer = values.Answer
            };
        }
    }
}
