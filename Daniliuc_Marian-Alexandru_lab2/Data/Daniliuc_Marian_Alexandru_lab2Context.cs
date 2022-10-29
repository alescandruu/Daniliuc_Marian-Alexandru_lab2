using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Daniliuc_Marian_Alexandru_lab2.Models;

namespace Daniliuc_Marian_Alexandru_lab2.Data
{
    public class Daniliuc_Marian_Alexandru_lab2Context : DbContext
    {
        public Daniliuc_Marian_Alexandru_lab2Context (DbContextOptions<Daniliuc_Marian_Alexandru_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Daniliuc_Marian_Alexandru_lab2.Models.Book> Book { get; set; } = default!;
    }
}
