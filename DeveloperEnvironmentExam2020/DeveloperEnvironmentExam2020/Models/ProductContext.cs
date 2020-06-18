using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperEnvironmentExam2020.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        /// <remarks>
        ///  Et forsøg på at lave en Foreign key relation til Category,
        ///  så at den kan hentes fra dens Id i Product.
        ///  Gav desværre intet resultat.
        /// </remarks>


        //public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Pro)
        //}
    }
}
