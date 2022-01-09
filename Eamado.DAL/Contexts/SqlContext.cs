using Eamado.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamado.DAL.Contexts
{
   public class SqlContext:DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> o) : base(o)
        {
       
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API
            modelBuilder.Entity<Brand>().HasMany(hm => hm.Product).WithOne(wo => wo.Brand).OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ProductCategory>().HasKey(hk => new { hk.ProductID, hk.CategoryID });//Compozite key
        }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<HomePage> HomePage { get; set; }
        public DbSet<Category> Category{ get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ProductPicture> ProductPicture { get; set; }
     
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }





    }
}
