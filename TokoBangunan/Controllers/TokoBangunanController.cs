using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TokoBangunan.Models; 
using System.Text.Encodings.Web;
using TokoBangunan.Data;
using Microsoft.EntityFrameworkCore;

namespace TokoBangunan.Controllers
{
    public class TokoBangunan : Controller
    {
        public TokoBangunanDbContext _context;
        public TokoBangunan(TokoBangunanDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Produks.ToList();
            return View(list);
        }

        public IActionResult Details(int id)
        {
            var Produk = _context.Produks.Find(id);
            return View(Produk);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Stok,Harga,KategoriId,Nama,Link")] Produk produk)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Produks.Add(produk);
                    _context.SaveChanges();
                }
                catch(DbUpdateException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        
         public IActionResult Create()
         {
             return View();
         }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}