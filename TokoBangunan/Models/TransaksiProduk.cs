using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TokoBangunan.Models
{
    public class TransaksiProduk
    {
        public int Id { get; set;}
        public int ProdukId { get; set; }
        public virtual Produk Produk { get; set; }
        public int TransaksiId { get; set; }
        public virtual Transaksi Transaksi { get; set; }
        public decimal Jumlah {get; set; }
        public decimal Harga {get; set; }       
    }
}