using DesignPatern.TemplateMethod.TemplatePatern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicIndex()
        {
            Plans plans = new BasicPlan();
            ViewBag.v1 = plans.PlanType("Basic Plan");
            ViewBag.v2 = plans.CountPerson(1);
            ViewBag.v3 = plans.Price(6.99);
            ViewBag.v4 = plans.Content("Movie and Series");
            ViewBag.v5 = plans.Resolution("1080p");
            return View();
        }

        public IActionResult UltraIndex()
        {
            Plans plans = new UltraPlan();
            ViewBag.v1 = plans.PlanType("Ultra Plan");
            ViewBag.v2 = plans.CountPerson(5);
            ViewBag.v3 = plans.Price(12.99);
            ViewBag.v4 = plans.Content("Movie, Series and Documentaries");
            ViewBag.v5 = plans.Resolution("4K");
            return View();
        }
    }
}
