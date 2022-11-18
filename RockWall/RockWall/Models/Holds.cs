using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Holds
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HoldID { get; set; }
        [ForeignKey("Sections")]
        public Tuple<int, int>? Position { get; set; }

        [ForeignKey("Spots")]
        public int Spot { get; set; }
        public string? Color { get; set;}
        public string? Type { get; set;}
        [ForeignKey("Routes")]
        public ICollection<string> Name { get; set; }
    }
}

