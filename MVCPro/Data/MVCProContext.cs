using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCPro.Models
{
    public class MVCProContext : DbContext
    {
        public MVCProContext (DbContextOptions<MVCProContext> options)
            : base(options)
        {
        }

        public DbSet<MVCPro.Models.Person> Person { get; set; }
    }
}
