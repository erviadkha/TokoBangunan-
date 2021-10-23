using System;
using System.ComponentModel.DataAnnotations;

namespace TokoBangunan.Models
{
    public class TransaksiProduk
    {
        public int Id { get; set;}
        public string Produk { get; set;}
        public string Transaksi { get; set;}
        public decimal Jumlah {get; set;}
        public decimal Harga {get; set;}
        
    }
}