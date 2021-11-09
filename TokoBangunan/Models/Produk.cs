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
        public int KategoriId { get; set; }
        public virtual Kategori Kategoris { get; set; }
        public string Nama { get; set; }
    }
}