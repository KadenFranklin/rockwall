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

namespace RockWall.Pages.Spots
{
    public class EditModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public EditModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Spot Spot { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Spot == null)
            {
                return NotFound();
            }

            var spot =  await _context.Spot.FirstOrDefaultAsync(m => m.SpotID == id);
            if (spot == null)
            {
                return NotFound();
            }
            Spot = spot;
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

            _context.Attach(Spot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpotExists(Spot.SpotID))
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

        private bool SpotExists(int id)
        {
          return _context.Spot.Any(e => e.SpotID == id);
        }
    }
}
