using Microsoft.EntityFrameworkCore;
using TokoBangunan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TokoBangunan.Data
{
    public class TokoBangunanDbContext : IdentityDbContext<Pengguna>
    {
        public TokoBangunanDbContext (DbContextOptions<TokoBangunanDbContext> options) : base(options)
        {}

        public DbSet<Kategori> Kategoris {get; set;}
        public DbSet<Produk> Produks {get; set;}
        public DbSet<Transaksi> Transaksis {get; set;}
        public DbSet<TransaksiProduk> TransaksiProduks {get; set;}

    }
}