using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Measurement as an owned type
            modelBuilder.Entity<Dog>().OwnsOne(d => d.Height);
            modelBuilder.Entity<Dog>().OwnsOne(d => d.Weight);

            base.OnModelCreating(modelBuilder);
        }
    }
}