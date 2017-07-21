using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.JQuery.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
