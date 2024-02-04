using BakeryProject.DAL.Context;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using BakeryProject.MediatorDesignPattern.Results;
using BakeryProject.MediatorDesignPattern.Results.Questions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BakeryProject.MediatorDesignPattern.Handlers.Questions
{
    public class GetAllQuestionsQueryHandler : IRequestHandler<GetAllQuestionsQuery, List<GetAllQuestionsQueryResult>>
    {
        private readonly SaleContext _saleContext;

        public GetAllQuestionsQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public async Task<List<GetAllQuestionsQueryResult>> Handle(GetAllQuestionsQuery request, CancellationToken cancellationToken)
        {
            return await _saleContext.Questions.Select(x => new GetAllQuestionsQueryResult
            {
              QuestionsID = x.QuestionsID,
              Question = x.Question,
              Answer = x.Answer
            }).ToListAsync();
        }
    }
}
