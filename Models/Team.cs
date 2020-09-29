using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsPlus.Models {
    public class Team {
        [Key]
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // this is the 1 .. * relation
        public List<Player> Platers { get; set; }

        public static List<Team> GetTeams () {
            List<Team> teams = new List<Team> {
                new Team () {
                TeamName = "Canucks",
                City = "Vancouver",
                Country = "Canada",
                },
                new Team () {
                TeamName = "Oilers",
                City = "Edmonton",
                Country = "Canada",
                },
                new Team () {
                TeamName = "Flames",
                City = "Calgary",
                Country = "Canada",
                },
                new Team () {
                TeamName = "Leafs",
                City = "Toronto",
                Country = "Canada",
                },
            };

            return teams;
        }
    }
}