using DesignPatern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPatern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatern.ChainOfResponsibility.Controllers
{
    public class Default : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.setNextApprover(managerAsistant);
            managerAsistant.setNextApprover(manager);
            manager.setNextApprover(areaDirector);

            treasurer.ProcessRequest(model);

            return View();
        }
    }
}
