using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Walls
{
    public class DetailsModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public DetailsModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

      public Wall Wall { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Wall == null)
            {
                return NotFound();
            }

            var wall = await _context.Wall.FirstOrDefaultAsync(m => m.ID == id);
            if (wall == null)
            {
                return NotFound();
            }
            else 
            {
                Wall = wall;
            }
            return Page();
        }
    }
}
