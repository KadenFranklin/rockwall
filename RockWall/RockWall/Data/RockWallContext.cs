using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RockWall.Models;

namespace RockWall.Data
{
    public class RockWallContext : DbContext
    {
        public RockWallContext (DbContextOptions<RockWallContext> options)
            : base(options)
        {
        }

        public DbSet<RockWall.Models.Holds> Holds { get; set; } = default!;
    }
}
