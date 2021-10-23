using System;
using System.ComponentModel.DataAnnotations;

namespace TokoBangunan.Models
{
    public class Pengguna
    {
        public int Id { get; set; }
        public string Username { get; set;}
        public string Password { get; set;}
    }
}