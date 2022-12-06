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
using Route = RockWall.Models.Route;

namespace RockWall.Pages.Routes
{
    public class EditModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public EditModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Route Route { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Route == null)
            {
                return NotFound();
            }

            var route =  await _context.Route.FirstOrDefaultAsync(m => m.Name == id);
            if (route == null)
            {
                return NotFound();
            }
            Route = route;
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

            _context.Attach(Route).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteExists(Route.Name))
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

        private bool RouteExists(string id)
        {
          return _context.Route.Any(e => e.Name == id);
        }
    }
}
