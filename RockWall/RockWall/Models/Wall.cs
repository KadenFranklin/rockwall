
namespace RockWall.Models
{
    public class Wall
    {
        public int ID { get; set; }
        public string historian { get; set; }
        public string year { get; set; }
        public string file { get; set; }
        public IList<Section> SectionList { get; set; }
        public IList<Route> RouteList { get; set; }

    }
}

//Get_new_image()
// Scale / find_wall()
// Get_new_image()
// Verify identity()
