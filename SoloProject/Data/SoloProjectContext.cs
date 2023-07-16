using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoloProject.Models;

namespace SoloProject.Data
{
    public class SoloProjectContext : DbContext
    {
        public SoloProjectContext (DbContextOptions<SoloProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SoloProject.Models.Movie> Movie { get; set; } = default!;
    }
}
