
using BakeryProject.MediatorDesignPattern.Commands;
using BakeryProject.MediatorDesignPattern.Commands.Gallery;
using BakeryProject.MediatorDesignPattern.Handlers;
using BakeryProject.MediatorDesignPattern.Queries;
using BakeryProject.MediatorDesignPattern.Queries.Gallery;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BakeryProject.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IMediator _mediator;
        public GalleryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGalleryQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateGallery()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateGallery(CreateGalleryCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteGallery(int id)
        {
            await _mediator.Send(new RemoveGalleryCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateGallery(int id)
        {
            var values = await _mediator.Send(new GetGalleryByIdQuery(id)); ;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateGallery(UpdateGalleryCommand command)
        {
            await _mediator.Send(command); ;
            return RedirectToAction("Index");
        }
    }
}
