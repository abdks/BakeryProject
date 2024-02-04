
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.HelpSupport;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.HelpSupport;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class HelpSupportController : Controller
    {
        private readonly IMediator _mediator;
        public HelpSupportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllHelpSupportQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateHelpSupport()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateHelpSupport(CreateHelpSupportCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteHelpSupport(int id)
        {
            await _mediator.Send(new RemoveHelpSupportCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateHelpSupport(int id)
        {
            var values = await _mediator.Send(new GetHelpSupportByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateHelpSupport(UpdateHelpSupportCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
