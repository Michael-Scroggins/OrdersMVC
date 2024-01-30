using LogisticsMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var orders = await _context.Order.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).ToListAsync();
            return View(orders);
        }



    }
}
