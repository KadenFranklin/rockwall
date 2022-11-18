using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Spots
    {  
        [Key]
        public int Spot { get; set; }
        [ForeignKey("Sections")]
        public Tuple<int, int>? Position { get; set; }
        public bool has_hold { get; set; }

    }
}
