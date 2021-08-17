using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class DevContext : DbContext
    {
        public DevContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.0.196;Initial Catalog=Developers;Persist Security Info=True;User ID=developers;Password=Asd123@");
        }
        DbSet<Address> Addresses { get; set; }
        DbSet<Contacts> Contacts { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Developer> Developers { get; set; }
    }
}
