
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Messages;
using BakeryProject.MediatorDesignPattern.Commands.Teams;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.Messages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMediator _mediator;
        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllMessagesQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateMessages()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessages(CreateMessagesCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteMessages(int id)
        {
            await _mediator.Send(new RemoveMessagesCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateMessages(int id)
        {
            var values = await _mediator.Send(new GetMessagesByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMessages(UpdateMessagesCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
