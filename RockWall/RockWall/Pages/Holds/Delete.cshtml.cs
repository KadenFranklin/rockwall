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
    public class DeleteModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public DeleteModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Holds == null)
            {
                return NotFound();
            }
            var holds = await _context.Holds.FindAsync(id);

            if (holds != null)
            {
                Holds = holds;
                _context.Holds.Remove(Holds);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
