using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockWall.Data;
using RockWall.Models;

namespace RockWall.Pages.Walls
{
    public class IndexModel : PageModel
    {
        private readonly RockWall.Data.RockWallContext _context;

        public IndexModel(RockWall.Data.RockWallContext context)
        {
            _context = context;
        }

        public IList<Wall> Wall { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Wall != null)
            {
                Wall = await _context.Wall.ToListAsync();
            }
        }
    }
}
