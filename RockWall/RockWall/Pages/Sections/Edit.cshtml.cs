using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Sections
{
    public class EditModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public EditModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Section Section { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Loc id)
        {
            if (id == null || _context.Section == null)
            {
                return NotFound();
            }
            var section = await _context.Section.FirstOrDefaultAsync(m => m.Position == id);
            if (section == null)
            {
                return NotFound();
            }
            Section = section;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Section).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(Section.Position))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SectionExists(Loc id)
        {
          return _context.Section.Any(e => e.Position == id);
        }
    }
}
