﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieWebApp.Models;

namespace MovieWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieWebApp.Models.MovieWebAppContext _context;

        public IndexModel(MovieWebApp.Models.MovieWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
