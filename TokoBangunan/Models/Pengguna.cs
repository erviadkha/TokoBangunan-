using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TokoBangunan.Models
{
    public class Pengguna
    {
        public int Id { get; set; }
        public string Username { get; set;}
        public string Password { get; set;}
        public virtual List<Pengguna> Penggunas { get; set; }
    }
}