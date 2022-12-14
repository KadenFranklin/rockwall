using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Route
    {
        [Key]
        public string Name { get; set; }
        public string Date { get; set; }
        public string Setter { get; set; }
        public string Grade { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }
        public List<Hold> AssociatedHolds{ get; set; }
    }
}

//Get_Assoc_Holds
// Should make some sort function for the order of holds in a route
// by Sec(x, y) then by # in spotlist