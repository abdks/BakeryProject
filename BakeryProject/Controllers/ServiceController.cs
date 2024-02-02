using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.Service;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.Service;
using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.Service;
using Microsoft.AspNetCore.Mvc;
using BakeryProject.CQRSPattern.Results.Service;

namespace BakeryProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly GetServiceQueryHandler _getServiceQueryHandler;
        private readonly CreateServiceCommandHandler _createServiceCommandHandler;
        private readonly GetServiceByIdQueryHandler _getServiceByIdQueryHandler;
        private readonly UpdateServiceCommandHandler _updateServiceCommandHandler;
        private readonly RemoveServiceCommandHandler _removeServiceCommandHandler;
        public ServiceController(GetServiceQueryHandler getServiceQueryHandler, CreateServiceCommandHandler createServiceCommandHandler, GetServiceByIdQueryHandler getServiceByIdQueryHandler, UpdateServiceCommandHandler updateServiceCommandHandler, RemoveServiceCommandHandler removeServiceCommandHandler)
        {
            _getServiceQueryHandler = getServiceQueryHandler;
            _createServiceCommandHandler = createServiceCommandHandler;
            _getServiceByIdQueryHandler = getServiceByIdQueryHandler;
            _updateServiceCommandHandler = updateServiceCommandHandler;
            _removeServiceCommandHandler = removeServiceCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getServiceQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(CreateServiceCommand command)
        {
            _createServiceCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = _getServiceByIdQueryHandler.Handle(new GetServiceByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(UpdateServiceCommand command)
        {
            _updateServiceCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            _removeServiceCommandHandler.Handle(new RemoveServiceCommand(id));
            return RedirectToAction("Index");
        }
    }
}
