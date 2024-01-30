using Microsoft.AspNetCore.Mvc;

namespace LogisticsMVC.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
