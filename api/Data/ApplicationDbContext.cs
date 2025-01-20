using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.Data
{

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        
        }

        public DbSet<api.Models.Users> Users { get; set; } //створення таблиці Users
    }

}
