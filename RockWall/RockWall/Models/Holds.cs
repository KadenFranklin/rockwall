using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Holds
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [ForeignKey("Position")] {get; set;}
        public Tuple<T1, T2>? Position { get; set;}
        [ForeignKey("Spot")] {get; set;}
        public int Spot { get; set;}
        public string? Color { get; set;}
        public string? Type { get; set;}
        public List Routes { get; set; }
    }
}

