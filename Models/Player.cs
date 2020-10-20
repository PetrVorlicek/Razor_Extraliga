using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace EHL_Codecademy.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public int? PlayerNumber { get; set; }
        

        public string Name { get; set; }

        public DateTime? Birthday { get; set; }

        public string Position { get; set; }

        public string Stick { get; set; }

        public int? Height { get; set; }
        public int? Weight { get; set; }
        public Team TeamPlayed { get; set; }

    }
}
