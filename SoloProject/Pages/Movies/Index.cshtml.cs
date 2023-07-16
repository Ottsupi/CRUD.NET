using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoloProject.Data;
using SoloProject.Models;

namespace SoloProject.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly SoloProject.Data.SoloProjectContext _context;

        public IndexModel(SoloProject.Data.SoloProjectContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
