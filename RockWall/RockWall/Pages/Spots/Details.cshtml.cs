using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Spots
{
    public class DetailsModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public DetailsModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

      public Spot Spot { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Spot == null)
            {
                return NotFound();
            }

            var spot = await _context.Spot.FirstOrDefaultAsync(m => m.SpotID == id);
            if (spot == null)
            {
                return NotFound();
            }
            else 
            {
                Spot = spot;
            }
            return Page();
        }
    }
}
