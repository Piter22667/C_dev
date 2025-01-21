using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.Data
{

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        
        }

        public DbSet<api.Models.Users> Users { get; set; } //створення таблиці Users

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<api.Models.Users>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.login).IsRequired().HasMaxLength(20);
                entity.Property(e => e.password).IsRequired().HasMaxLength(60);
                entity.Property(e => e.name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.surname).IsRequired().HasMaxLength(50);
                entity.Property(e => e.lastName).HasMaxLength(50);
            });
        }

    }

}
