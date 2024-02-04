
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.CompanyNews;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.CompanyNews;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class CompanyNewsController : Controller
    {
        private readonly IMediator _mediator;
        public CompanyNewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllCompanyNewsQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCompanyNews()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCompanyNews(CreateCompanyNewsCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteCompanyNews(int id)
        {
            await _mediator.Send(new RemoveCompanyNewsCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCompanyNews(int id)
        {
            var values = await _mediator.Send(new GetCompanyNewsByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCompanyNews(UpdateCompanyNewsCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
