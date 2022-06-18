using Microsoft.AspNetCore.Mvc;

namespace TesteKeyworks.WebApp.MVC.Controllers
{
    public class MaterialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
