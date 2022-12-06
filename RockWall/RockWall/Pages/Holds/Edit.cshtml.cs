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

namespace RockWall.Pages.Holds
{
    public class EditModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public EditModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hold Hold { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Hold == null)
            {
                return NotFound();
            }

            var hold =  await _context.Hold.FirstOrDefaultAsync(m => m.ID == id);
            if (hold == null)
            {
                return NotFound();
            }
            Hold = hold;
           ViewData["SpotID"] = new SelectList(_context.Set<Spot>(), "SpotID", "SpotID");
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

            _context.Attach(Hold).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoldExists(Hold.ID))
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

        private bool HoldExists(int id)
        {
          return _context.Hold.Any(e => e.ID == id);
        }
    }
}
