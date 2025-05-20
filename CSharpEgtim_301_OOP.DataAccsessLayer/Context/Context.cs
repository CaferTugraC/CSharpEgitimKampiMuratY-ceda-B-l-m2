using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgtim_301_OOP.EntityLayer.Concrete;

namespace CSharpEgtim_301_OOP.DataAccsessLayer.Context
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get;  set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Custoemers { get; set; }
        public DbSet<Admin> Admins { get; set; }  
    }
}
