
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.AboutCard;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.AboutCard;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class AboutCardController : Controller
    {
        private readonly IMediator _mediator;
        public AboutCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllAboutCardQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAboutCard()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutCard(CreateAboutCardCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteAboutCard(int id)
        {
            await _mediator.Send(new RemoveAboutCardCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAboutCard(int id)
        {
            var values = await _mediator.Send(new GetAboutCardByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAboutCard(UpdateAboutCardCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
