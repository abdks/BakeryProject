using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.TwoPage;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.TwoPage;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.TwoPage;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.TwoPage;

namespace BakeryProject.Controllers
{
    public class TwoPageController : Controller
    {
        private readonly GetTwoPageQueryHandler _getTwoPageQueryHandler;
        private readonly CreateTwoPageCommandHandler _createTwoPageCommandHandler;
        private readonly GetTwoPageByIdQueryHandler _getTwoPageByIdQueryHandler;
        private readonly UpdateTwoPageCommandHandler _updateTwoPageCommandHandler;
        private readonly RemoveTwoPageCommandHandler _removeTwoPageCommandHandler;
        public TwoPageController(GetTwoPageQueryHandler getTwoPageQueryHandler, CreateTwoPageCommandHandler createTwoPageCommandHandler, GetTwoPageByIdQueryHandler getTwoPageByIdQueryHandler, UpdateTwoPageCommandHandler updateTwoPageCommandHandler, RemoveTwoPageCommandHandler removeTwoPageCommandHandler)
        {
            _getTwoPageQueryHandler = getTwoPageQueryHandler;
            _createTwoPageCommandHandler = createTwoPageCommandHandler;
            _getTwoPageByIdQueryHandler = getTwoPageByIdQueryHandler;
            _updateTwoPageCommandHandler = updateTwoPageCommandHandler;
            _removeTwoPageCommandHandler = removeTwoPageCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getTwoPageQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTwoPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTwoPage(CreateTwoPageCommand command)
        {
            _createTwoPageCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateTwoPage(int id)
        {
            var values = _getTwoPageByIdQueryHandler.Handle(new GetTwoPageByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTwoPage(UpdateTwoPageCommand command)
        {
            _updateTwoPageCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTwoPage(int id)
        {
            _removeTwoPageCommandHandler.Handle(new RemoveTwoPageCommand(id));
            return RedirectToAction("Index");
        }
    }
}
