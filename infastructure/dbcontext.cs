using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using domain;
using Microsoft.EntityFrameworkCore;

namespace infastructure
{
    class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-1LBQD98;Initial Catalog=lab2iti;Integrated Security=True")
        { }
        public DbSet<Category> Catigorys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<order_details> Order_details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }

   
}