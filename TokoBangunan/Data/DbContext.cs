using Microsoft.EntityFrameworkCore;
using TokoBangunan.Models;

namespace TokoBangunan.Data
{
    public class TokoBangunanDbContext : DbContext
    {
        public TokoBangunanDbContext (DbContextOptions<TokoBangunanDbContext> options) : base(options)
        {}

        public DbSet<Kategori> Kategoris {get; set;}
        public DbSet<Pengguna> Penggunas {get; set;}
        public DbSet<Produk> Produks {get; set;}
        public DbSet<Transaksi> Transaksis {get; set;}
        public DbSet<TransaksiProduk> TransaksiProduks {get; set;}

    }
}