using System.ComponentModel.DataAnnotations;

namespace RockWall.Models
{
    public class Sections
    {
        [Key]
        public Tuple<int, int>? Position { get; set; }
        public ICollection<Spots>? Spot_list { get; set; }

    }
}
