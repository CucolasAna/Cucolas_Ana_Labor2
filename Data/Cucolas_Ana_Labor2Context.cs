using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cucolas_Ana_Labor2.Models;

namespace Cucolas_Ana_Labor2.Data
{
    public class Cucolas_Ana_Labor2Context : DbContext
    {
        public Cucolas_Ana_Labor2Context (DbContextOptions<Cucolas_Ana_Labor2Context> options)
            : base(options)
        {
        }

        public DbSet<Cucolas_Ana_Labor2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cucolas_Ana_Labor2.Models.Publisher>? Publisher { get; set; }
    }
}
