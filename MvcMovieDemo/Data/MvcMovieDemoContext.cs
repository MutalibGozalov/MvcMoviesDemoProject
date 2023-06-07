using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieDemo.Models;

namespace MvcMovieDemo.Data
{
    public class MvcMovieDemoContext : DbContext
    {
        public MvcMovieDemoContext (DbContextOptions<MvcMovieDemoContext> options) : base(options)
        {
        }

        public DbSet<MvcMovieDemo.Models.Movie> Movie { get; set; } = default!;
    }
}
