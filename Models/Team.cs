using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EHL_Codecademy.Models
{
    public class Team
    {   
        [Key]
        public int TeamId { get; set; }
        //Basic info
        public string? ImgPath { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        //Score info
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int WinsOvertime { get; set; }
        public int LossesOvertime { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public ICollection<Player> Players { get; set; }

        //Calculated properties


    }
}
