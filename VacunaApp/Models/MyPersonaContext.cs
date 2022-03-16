using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacunaApp.Models
{
    public class MyPersonaContext : DbContext
    {
        public  DbSet<Persona> Personas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VBI96KNK\\SQLEXPRESS;Initial Catalog=Vacunados;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
