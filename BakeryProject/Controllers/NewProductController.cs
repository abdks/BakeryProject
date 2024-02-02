using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.NewProduct;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.NewProduct;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.NewProduct;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.NewProduct;

namespace BakeryProject.Controllers
{
    public class NewProductController : Controller
    {
        private readonly GetNewProductQueryHandler _getNewProductQueryHandler;
        private readonly CreateNewProductCommandHandler _createNewProductCommandHandler;
        private readonly GetNewProductByIdQueryHandler _getNewProductByIdQueryHandler;
        private readonly UpdateNewProductCommandHandler _updateNewProductCommandHandler;
        private readonly RemoveNewProductCommandHandler _removeNewProductCommandHandler;
        public NewProductController(GetNewProductQueryHandler getNewProductQueryHandler, CreateNewProductCommandHandler createNewProductCommandHandler, GetNewProductByIdQueryHandler getNewProductByIdQueryHandler, UpdateNewProductCommandHandler updateNewProductCommandHandler, RemoveNewProductCommandHandler removeNewProductCommandHandler)
        {
            _getNewProductQueryHandler = getNewProductQueryHandler;
            _createNewProductCommandHandler = createNewProductCommandHandler;
            _getNewProductByIdQueryHandler = getNewProductByIdQueryHandler;
            _updateNewProductCommandHandler = updateNewProductCommandHandler;
            _removeNewProductCommandHandler = removeNewProductCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getNewProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewProduct(CreateNewProductCommand command)
        {
            _createNewProductCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateNewProduct(int id)
        {
            var values = _getNewProductByIdQueryHandler.Handle(new GetNewProductByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateNewProduct(UpdateNewProductCommand command)
        {
            _updateNewProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNewProduct(int id)
        {
            _removeNewProductCommandHandler.Handle(new RemoveNewProductCommand(id));
            return RedirectToAction("Index");
        }
    }
}
