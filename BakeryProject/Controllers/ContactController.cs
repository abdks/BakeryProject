
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Contact;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.Contact;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMediator _mediator;
        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllContactQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _mediator.Send(new RemoveContactCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var values = await _mediator.Send(new GetContactByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
