
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Questions;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.Questions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly IMediator _mediator;
        public QuestionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllQuestionsQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateQuestions()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateQuestions(CreateQuestionsCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteQuestions(int id)
        {
            await _mediator.Send(new RemoveQuestionsCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateQuestions(int id)
        {
            var values = await _mediator.Send(new GetQuestionsByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateQuestions(UpdateQuestionsCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
