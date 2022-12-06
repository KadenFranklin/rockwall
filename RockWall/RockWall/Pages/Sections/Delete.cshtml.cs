using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Sections
{
    public class DeleteModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public DeleteModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Section Section { get; set; }

        public async Task<IActionResult> OnGetAsync(Loc id)
        {
            if (id != null && _context.Section != null)
            {
                var section = await _context.Section.FirstOrDefaultAsync(m => m.Position == id);

                if (section == null)
                {
                    return NotFound();
                }
                else
                {
                    Section = section;
                }
                return Page();
            }
            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(Loc id)
        {
            if (id == null || _context.Section == null)
            {
                return NotFound();
            }
            var section = await _context.Section.FindAsync(id);

            if (section != null)
            {
                Section = section;
                _context.Section.Remove(Section);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
