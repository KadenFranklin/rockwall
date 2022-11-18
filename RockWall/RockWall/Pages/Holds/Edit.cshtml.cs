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
        public Holds Holds { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Holds == null)
            {
                return NotFound();
            }

            var holds =  await _context.Holds.FirstOrDefaultAsync(m => m.ID == id);
            if (holds == null)
            {
                return NotFound();
            }
            Holds = holds;
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

            _context.Attach(Holds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoldsExists(Holds.ID))
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

        private bool HoldsExists(int id)
        {
          return _context.Holds.Any(e => e.ID == id);
        }
    }
}
