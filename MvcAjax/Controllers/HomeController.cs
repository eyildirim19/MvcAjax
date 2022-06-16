using Microsoft.AspNetCore.Mvc;

namespace MvcAjax.Controllers
{
    public class HomeController : Controller
    {
        public int Sayac
        {
            get
            {
                return HttpContext.Session.GetInt32("syc") == null ? 0 : (int)HttpContext.Session.GetInt32("syc");
            }
            set
            {
                HttpContext.Session.SetInt32("syc", value);
            }
        }

        public IActionResult Index()
        {
            return View(Sayac);
        }

        [HttpPost]
        public IActionResult Arttir()
        {
            Sayac++;

            return Json(Sayac); // geriye json dön..
        }
    }
}
