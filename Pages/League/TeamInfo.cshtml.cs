using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHL_Codecademy.Data;
using EHL_Codecademy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EHL_Codecademy.Pages.League
{
    public class TeamInfoModel : PageModel
    {
        private readonly PlayerContext _context;
        public TeamInfoModel(PlayerContext context)
        {
            _context = context;
        }
        public Team Team { get; set; }
        public List<Player> Players { get; set; }
        public async Task OnGetAsync(int Id)
        {
            Team = await _context.Teams
                .Include(team => team.Players)
                .AsNoTracking()
                .FirstOrDefaultAsync(team => team.TeamId == Id);
        }
    }
}
