using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.Slider;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.slider;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.Slider;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.Slider;

namespace BakeryProject.Controllers
{
    public class SliderController : Controller
    {
        private readonly GetSliderQueryHandler _getSliderQueryHandler;
        private readonly CreateSliderCommandHandler _createSliderCommandHandler;
        private readonly GetSliderByIdQueryHandler _getSliderByIdQueryHandler;
        private readonly UpdateSliderCommandHandler _updateSliderCommandHandler;
        private readonly RemoveSliderCommandHandler _removeSliderCommandHandler;
        public SliderController(GetSliderQueryHandler getSliderQueryHandler, CreateSliderCommandHandler createSliderCommandHandler, GetSliderByIdQueryHandler getSliderByIdQueryHandler, UpdateSliderCommandHandler updateSliderCommandHandler, RemoveSliderCommandHandler removeSliderCommandHandler)
        {
            _getSliderQueryHandler = getSliderQueryHandler;
            _createSliderCommandHandler = createSliderCommandHandler;
            _getSliderByIdQueryHandler = getSliderByIdQueryHandler;
            _updateSliderCommandHandler = updateSliderCommandHandler;
            _removeSliderCommandHandler = removeSliderCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getSliderQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderCommand command)
        {
            _createSliderCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var values = _getSliderByIdQueryHandler.Handle(new GetSliderByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderCommand command)
        {
            _updateSliderCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSlider(int id)
        {
            _removeSliderCommandHandler.Handle(new RemoveSliderCommand(id));
            return RedirectToAction("Index");
        }
    }
}
