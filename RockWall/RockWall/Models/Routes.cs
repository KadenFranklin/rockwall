﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockWall.Models
{
    public class Routes
    {
        [Key]
        public string Name { get; set; }
        public string Date { get; set; }
        public string Setter { get; set; }
        public string Grade { get; set; }
        public string Description { get; set; }
        public string? Notes { get; set; }
        public ICollection<Holds> HoldList{ get; set; }


    }
}
