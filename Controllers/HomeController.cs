using Microsoft.EntityFrameworkCore;
using PopAlexandru_Proiect2.Data;
using Microsoft.AspNetCore.Mvc;
using PopAlexandru_Proiect2.Models;
using PopAlexandru_Proiect2.Models.LibraryViewModels;
using System.Diagnostics;
using PopAlexandruCristian_Proiect.Data;

namespace PopAlexandru_Proiect2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Statistics()
        {
            IQueryable<OrderGroup> data =
            from order in _context.Orders
            group order by order.OrderDate into dateGroup
            select new OrderGroup()
            {
                OrderDate = dateGroup.Key,
                CarCount = dateGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }

        private readonly ILogger<HomeController> _logger;
        private readonly DealershipContext _context;
        public HomeController(ILogger<HomeController> logger, DealershipContext context)
        {
            _context = context;
            _logger = logger;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}