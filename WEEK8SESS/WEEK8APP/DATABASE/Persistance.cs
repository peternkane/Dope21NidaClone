using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEEK8APP.DTO;

namespace WEEK8APP.DATABASE
{
    public class Persistance : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Persistance(DbContextOptions<Persistance> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
