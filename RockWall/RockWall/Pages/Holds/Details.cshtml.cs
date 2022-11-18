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

      public Holds Holds { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Holds == null)
            {
                return NotFound();
            }

            var holds = await _context.Holds.FirstOrDefaultAsync(m => m.ID == id);
            if (holds == null)
            {
                return NotFound();
            }
            else 
            {
                Holds = holds;
            }
            return Page();
        }
    }
}
