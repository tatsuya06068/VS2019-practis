using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cafe.Models;

namespace cafe.Data
{
    public class cafeContext : DbContext
    {
        public cafeContext (DbContextOptions<cafeContext> options)
            : base(options)
        {
        }

        public DbSet<cafe.Models.Product> Product { get; set; }
    }
}
