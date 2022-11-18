using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Holds
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Hold_ID { get; set; }
        [ForeignKey("Sections")]
        public int Sect_ID { get; set;}
    
        [ForeignKey("Spots")]
        public int Spot_ID { get; set; }
        public string? Color { get; set;}
        public string? Type { get; set;}
        public ICollection<string> Routes { get; set; }
    }
}

