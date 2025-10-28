using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_pabon_yilber.Models;

namespace proyecto_pabon_yilber.Data

{
    public class dbcontex : DbContext
    {
        public dbcontex(DbContextOptions<dbcontex> options) : base(options)
        {
        }
        public DbSet<Usuariomodel> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuariomodel>().HasKey(U => U.UserID);
            modelBuilder.Entity<Usuariomodel>().Property(U =>U.UserID).ValueGeneratedOnAdd();
        }
    }
}
 