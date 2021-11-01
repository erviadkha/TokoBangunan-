using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TokoBangunan.Models
{
    public class Kategori
    {
        public int Id { get; set;}
        public string Nama { get; set;}
        public virtual List<Kategori> Kategoris { get; set; }
    }
}