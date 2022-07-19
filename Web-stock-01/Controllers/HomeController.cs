using Microsoft.AspNetCore.Mvc;

namespace EstoqueWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}