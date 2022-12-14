using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Spots
{
    public class CreateModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public CreateModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Spot Spot { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Spot.Add(Spot);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
