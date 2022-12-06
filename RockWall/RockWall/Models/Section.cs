using RockWall.Models;
using System.ComponentModel.DataAnnotations;

namespace RockWall.Models
{
    public enum Loc { 
    a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13,
    b0, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13,
    c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13,
    d0, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13,
    e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13,
    f0, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13,
    g0, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13,
    h0, h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12, h13,
    }
    public class Section
    {
        [Key]
        public Loc Position { get; set; }
        public IList<Spot> Spotlst { get; set; }// = new List<Spot>();
    }
}
// Get_spots()
// Get_holds()
// Display_spots / holds()
// Update_section()