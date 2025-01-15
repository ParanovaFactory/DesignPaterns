using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                Country = "Germany",
                City = "Berlin",
                Palace = "Berlin city gate"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                Country = "France",
                City = "Paris",
                Palace = "Eiffel Tower"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                Country = "Italy",
                City = "Venetian",
                Palace = "Gondola Tour"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                Country = "Italy",
                City = "Rome",
                Palace = "Kolessioum"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                Country = "Czechia",
                City = "Prague",
                Palace = "Big Square"
            });

            var iterator = visitRouteMover.CreateIterator();

            while(iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.Country + " " + iterator.CurrentItem.City + " " + iterator.CurrentItem.Palace);
            }

            ViewBag.v = strings;

            return View();
        }
    }
}
