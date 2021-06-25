using AppWithSQLite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSQLite.Database
{
    public class AppDbContext : DbContext
    {
        private readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public AppDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>();
            modelBuilder.Entity<Country>().HasIndex(n => n.Name).IsUnique();
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
