using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TokoBangunan.Models
{
    public class Produk
    {
        public int Id { get; set; }
        public decimal Stok { get; set;}
        public decimal Harga { get; set; }
        public string Kategori { get; set; }
        public string Nama { get; set; }
        public virtual List<Produk> Produks { get; set;}
    }
}