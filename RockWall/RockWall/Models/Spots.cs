using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Spots
    {  
        [Key]
        public int Spot_ID { get; set; }
        [ForeignKey("Sections")]
        public int Sect_ID { get; set; }
        public int Spot { get; set; }
        public bool has_hold { get; set; }

    }
}
