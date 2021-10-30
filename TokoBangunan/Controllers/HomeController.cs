using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TokoBangunan.Models; 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using TokoBangunan.Data;
using System.Text.Encodings.Web;

namespace TokoBangunan.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private UserManager<Pengguna> _userManager;
        private TokoBangunanDbContext _context;
        private ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TokoBangunanDbContext context, UserManager<Pengguna> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var user = _context.Users.Find(userId);
            return View(user);
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
