using System.ComponentModel.DataAnnotations;

namespace RockWall.Models
{
    public class Spots
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Position")] {get; set;}
        public Tuple Position { get; set; }
        public int Spot { get; set; }
        public bool has_hold { get; set; }

    }
}
