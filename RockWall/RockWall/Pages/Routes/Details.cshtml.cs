using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;
using Route = RockWall.Models.Route;

namespace RockWall.Pages.Routes
{
    public class DetailsModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public DetailsModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

      public Route Route { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Route == null)
            {
                return NotFound();
            }

            var route = await _context.Route.FirstOrDefaultAsync(m => m.Name == id);
            if (route == null)
            {
                return NotFound();
            }
            else 
            {
                Route = route;
            }
            return Page();
        }
    }
}
