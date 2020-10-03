using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWeb.Models
{
   public class ConectaBanco : DbContext
    {
        public ConectaBanco(DbContextOptions<ConectaBanco> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuarios> Usuarios { get; set; }

    }
}
