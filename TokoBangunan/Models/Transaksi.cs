using System;
using System.ComponentModel.DataAnnotations;

namespace TokoBangunan.Models
{
    public class Transaksi
    {
        public int Id {get; set;}
        public string Pengguna {get; set;}
        public DateTime TanggalTransaksi { get; set;}
    }
}