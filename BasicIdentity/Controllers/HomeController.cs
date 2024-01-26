using BasicIdentity.Data;
using BasicIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BasicIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddYTDetails()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddYTDetails(YtDetail model)
        {
            await _context.ytdetail.AddAsync(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> AddPost()
        {
            ViewBag.Categories = await _context.category.ToListAsync() ?? new List<Category>();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(Post model)
        {
            await _context.postpoetry.AddAsync(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}