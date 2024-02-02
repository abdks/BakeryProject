using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.OnePage;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.OnePage;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.OnePage;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.OnePage;

namespace BakeryProject.Controllers
{
    public class OnePageController : Controller
    {
        private readonly GetOnePageQueryHandler _getOnePageQueryHandler;
        private readonly CreateOnePageCommandHandler _createOnePageCommandHandler;
        private readonly GetOnePageByIdQueryHandler _getOnePageByIdQueryHandler;
        private readonly UpdateOnePageCommandHandler _updateOnePageCommandHandler;
        private readonly RemoveOnePageCommandHandler _removeOnePageCommandHandler;
        public OnePageController(GetOnePageQueryHandler getOnePageQueryHandler, CreateOnePageCommandHandler createOnePageCommandHandler, GetOnePageByIdQueryHandler getOnePageByIdQueryHandler, UpdateOnePageCommandHandler updateOnePageCommandHandler, RemoveOnePageCommandHandler removeOnePageCommandHandler)
        {
            _getOnePageQueryHandler = getOnePageQueryHandler;
            _createOnePageCommandHandler = createOnePageCommandHandler;
            _getOnePageByIdQueryHandler = getOnePageByIdQueryHandler;
            _updateOnePageCommandHandler = updateOnePageCommandHandler;
            _removeOnePageCommandHandler = removeOnePageCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getOnePageQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateOnePage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOnePage(CreateOnePageCommand command)
        {
            _createOnePageCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateOnePage(int id)
        {
            var values = _getOnePageByIdQueryHandler.Handle(new GetOnePageByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateOnePage(UpdateOnePageCommand command)
        {
            _updateOnePageCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteOnePage(int id)
        {
            _removeOnePageCommandHandler.Handle(new RemoveOnePageCommand(id));
            return RedirectToAction("Index");
        }
    }
}
