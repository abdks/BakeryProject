using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.FiveProduct;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.FiveProduct;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.FiveProduct;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.FiveProduct;

namespace BakeryProject.Controllers
{
    public class FiveProductController : Controller
    {
        private readonly GetFiveProductQueryHandler _getFiveProductQueryHandler;
        private readonly CreateFiveProductCommandHandler _createFiveProductCommandHandler;
        private readonly GetFiveProductByIdQueryHandler _getFiveProductByIdQueryHandler;
        private readonly UpdateFiveProductCommandHandler _updateFiveProductCommandHandler;
        private readonly RemoveFiveProductCommandHandler _removeFiveProductCommandHandler;
        public FiveProductController(GetFiveProductQueryHandler getFiveProductQueryHandler, CreateFiveProductCommandHandler createFiveProductCommandHandler, GetFiveProductByIdQueryHandler getFiveProductByIdQueryHandler, UpdateFiveProductCommandHandler updateFiveProductCommandHandler, RemoveFiveProductCommandHandler removeFiveProductCommandHandler)
        {
            _getFiveProductQueryHandler = getFiveProductQueryHandler;
            _createFiveProductCommandHandler = createFiveProductCommandHandler;
            _getFiveProductByIdQueryHandler = getFiveProductByIdQueryHandler;
            _updateFiveProductCommandHandler = updateFiveProductCommandHandler;
            _removeFiveProductCommandHandler = removeFiveProductCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getFiveProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFiveProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFiveProduct(CreateFiveProductCommand command)
        {
            _createFiveProductCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateFiveProduct(int id)
        {
            var values = _getFiveProductByIdQueryHandler.Handle(new GetFiveProductByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFiveProduct(UpdateFiveProductCommand command)
        {
            _updateFiveProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFiveProduct(int id)
        {
            _removeFiveProductCommandHandler.Handle(new RemoveFiveProductCommand(id));
            return RedirectToAction("Index");
        }
    }
}
