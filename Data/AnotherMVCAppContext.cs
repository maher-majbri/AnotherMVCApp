using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnotherMVCApp.Models;

namespace AnotherMVCApp.Data
{
    public class AnotherMVCAppContext : DbContext
    {
        public AnotherMVCAppContext (DbContextOptions<AnotherMVCAppContext> options) : base(options)
        {
        }

        //Database Table
        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
