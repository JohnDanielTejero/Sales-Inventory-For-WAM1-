using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using System.Data;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Database.Context
{


    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SalesInventoryContext : DbContext
    {
        public SalesInventoryContext() : base("name=SalesInventoryContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesItem> SalesItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesItem>()
                .HasKey(si => new { si.SalesId, si.ProductId });

            modelBuilder.Entity<User>()
                .HasRequired(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleID);

            modelBuilder.Entity<Stock>()
                .HasRequired(s => s.Product)
                .WithRequiredDependent(p => p.Stock);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);

            modelBuilder.Entity<SalesItem>()
                .HasRequired(si => si.Sale)
                .WithMany(s => s.SalesItems)
                .HasForeignKey(si => si.SalesId);

            modelBuilder.Entity<SalesItem>()
                .HasRequired(si => si.Product)
                .WithMany(p => p.SalesItems)
                .HasForeignKey(si => si.ProductId);

            modelBuilder.Entity<Sale>()
                .HasRequired(s => s.User)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.UserID);
        
        }
    }

}
