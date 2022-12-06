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

        public DbSet<RockWall.Models.Hold> Hold { get; set; }
        public DbSet<RockWall.Models.Spot> Spot { get; set; }
        public DbSet<RockWall.Models.Section> Section { get; set; }
        public DbSet<RockWall.Models.Route> Route { get; set; }
        public DbSet<RockWall.Models.Wall> Wall { get; set; }
    }
}
