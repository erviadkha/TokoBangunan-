using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TokoBangunan.Data;
using TokoBangunan.Models;

namespace TokoBangunan.Controllers
{
    public class TransaksiController : Controller
    {

        private TokoBangunanDbContext _context;
        private UserManager<Pengguna> _userManager;        
        public TransaksiController(TokoBangunanDbContext context, UserManager<Pengguna> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        
            public IActionResult Create(int id)
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create([Bind(Prefix = "TambahTransaksi")] TambahTransaksiViewModel transaksiProduk, int id)
            {
                var data = _context.Produks.Find(id);
                var transaksiProduks = new List<TransaksiProduk>();
                var userId = _userManager.GetUserId(User);
                var transaksi = new Transaksi()
                {
                    PenggunaId = userId,
                    TanggalTransaksi = DateTime.UtcNow
                };
                var transaksiLain = new TransaksiProduk()
                {
                    Harga = transaksiProduk.Harga,
                    Jumlah = transaksiProduk.Harga,
                    ProdukId = id,                                    
                };
                transaksiProduks.Add(transaksiLain);
                transaksi.TransaksiProduks = transaksiProduks;
                _context.Transaksis.Add(transaksi);
                _context.SaveChanges();
                return RedirectToAction("DataPembeli");
            }

            public IActionResult DataPembeli(int id) 
            {
                 var list = _context.TransaksiProduks.Find(id);
                 return View(list);
            } 

    }
}