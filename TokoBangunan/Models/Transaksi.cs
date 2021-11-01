using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TokoBangunan.Models
{
    public class Transaksi
    {
        public int Id {get; set;}
        public string Pengguna {get; set;}
        public DateTime TanggalTransaksi { get; set;}
        public virtual List<Transaksi> Transaksis { get; set;}
    }
}