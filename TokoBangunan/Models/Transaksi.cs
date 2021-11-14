using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TokoBangunan.Models
{
    public class Transaksi
    {
        public int Id { get; set;}
        public string PenggunaId { get; set; }
        public virtual Pengguna Pengguna { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public virtual List<TransaksiProduk> TransaksiProduks { get; set; }
    }
}