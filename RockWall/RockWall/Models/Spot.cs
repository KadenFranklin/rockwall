using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Spot
    {  
        [Key]
        public int SpotID { get; set; }
        public int loc { get; set; }
        public Loc Position { get; set; }
        public Section Section { get; set; }
        public Hold? Hold { get; set; }
    }
}

// update spot() - what parameters should this take?