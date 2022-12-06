using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Holds
{
    public class DetailsModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public DetailsModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

      public Hold Hold { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Hold == null)
            {
                return NotFound();
            }

            var hold = await _context.Hold.FirstOrDefaultAsync(m => m.ID == id);
            if (hold == null)
            {
                return NotFound();
            }
            else 
            {
                Hold = hold;
            }
            return Page();
        }
    }
}
