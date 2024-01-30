using LogisticsMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsMVC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)

        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }



    }
}
