using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie36.Models;

namespace RazorPagesMovie36.Data
{
    public class RazorPagesMovie36Context : DbContext
    {
        public RazorPagesMovie36Context (DbContextOptions<RazorPagesMovie36Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie36.Models.Movie> Movie { get; set; }
    }
}
