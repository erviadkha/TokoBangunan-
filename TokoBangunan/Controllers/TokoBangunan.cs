using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TokoBangunan.Models; 
using System.Text.Encodings.Web;

namespace TokoBangunan.Controllers
{
    public class TokoBangunan : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult Privacy()
        {
            return View();
        }
    }
}