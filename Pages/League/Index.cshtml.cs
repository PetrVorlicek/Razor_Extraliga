using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHL_Codecademy.Data;
using EHL_Codecademy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EHL_Codecademy.Pages
{
    public class LeagueModel : PageModel
    {
        private readonly PlayerContext _context;
        public List<Team> Teams { get; set; }
        public Dictionary<string, int> TeamPoints { get; set; } = new Dictionary<string, int>();

        //public string SearchString { get; set; } = "Ano";
        public LeagueModel(PlayerContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(string sort)
        {
            // getting teams from database using LINQ
            var teams = from team in _context.Teams select team;

            //sorting
            switch(sort)
            {
                case "team":
                    teams = from team in teams orderby team.Name select team;
                    break;
                case "city":
                    teams = from team in teams orderby team.City select team;
                    break;
                case "matches":
                    teams = from team in teams orderby team.TeamId select team;
                    break;
                case "wins":
                    teams = from team in teams orderby team.Wins descending select team;
                    break;
                case "winsovertime":
                    teams = from team in teams orderby team.WinsOvertime descending select team;
                    break;
                case "losessovertime":
                    teams = from team in teams orderby team.LossesOvertime select team;
                    break;
                case "losses":
                    teams = from team in teams orderby team.Losses select team;
                    break;
                default:
                    break;
            }


            Teams = await teams.AsNoTracking().ToListAsync();
            //computing values
            foreach (var team in Teams)
            {
                int points = 3 * team.Wins + 2 * team.WinsOvertime + team.LossesOvertime;
                TeamPoints.Add(team.Name, points);
            }
        }
    }
}
