using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EHL_Codecademy.Models;

namespace EHL_Codecademy.Data
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API: One to many
            modelBuilder.Entity<Player>()
            .HasOne(p => p.TeamPlayed)
            .WithMany(t => t.Players)
            .HasForeignKey(p => p.TeamID)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
