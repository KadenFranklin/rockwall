using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Hold
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string? Color { get; set; }
        public string? Type { get; set; }
        public int SpotID { get; set; }
        public Spot spot { get; set; }
        public List<Route> AssociatedRoutes { get; set; }
    }
}

//	Get_Assoc_Routes()