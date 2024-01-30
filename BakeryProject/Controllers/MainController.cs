using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.Main;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.Main;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.Main;

namespace BakeryProject.Controllers
{
    public class MainController : Controller
    {
        private readonly GetMainQueryHandler _getMainQueryHandler;
        private readonly CreateMainCommandHandler _createMainCommandHandler;
        private readonly GetMainByIdQueryHandler _getMainByIdQueryHandler;
        private readonly UpdateMainCommandHandler _updateMainCommandHandler;
        private readonly RemoveMainCommandHandler _removeMainCommandHandler;
        public MainController(GetMainQueryHandler getMainQueryHandler, CreateMainCommandHandler createMainCommandHandler, GetMainByIdQueryHandler getMainByIdQueryHandler, UpdateMainCommandHandler updateMainCommandHandler, RemoveMainCommandHandler removeMainCommandHandler)
        {
            _getMainQueryHandler = getMainQueryHandler;
            _createMainCommandHandler = createMainCommandHandler;
            _getMainByIdQueryHandler = getMainByIdQueryHandler;
            _updateMainCommandHandler = updateMainCommandHandler;
            _removeMainCommandHandler = removeMainCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getMainQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateMain()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMain(CreateMainCommand command)
        {
            _createMainCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateMain(int id)
        {
            var values = _getMainByIdQueryHandler.Handle(new GetMainByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateMain(UpdateMainCommand command)
        {
            _updateMainCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMain(int id)
        {
            _removeMainCommandHandler.Handle(new RemoveMainCommand(id));
            return RedirectToAction("Index");
        }
    }
}
