using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieWebApp.Models
{
    public class MovieWebAppContext : DbContext
    {
        public MovieWebAppContext (DbContextOptions<MovieWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieWebApp.Models.Movie> Movie { get; set; }
    }
}
