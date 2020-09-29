using Microsoft.EntityFrameworkCore;
using SportsPlus.Models;

namespace SportsPlus.Data {
    public static class DummyData {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Team>().HasData (
                Team.GetTeams()
            );
            modelBuilder.Entity<Player>().HasData (
                Player.GetPlayers()
            );
        }
    }
}