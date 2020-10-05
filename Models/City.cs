
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsPlus.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        public string Province  { get; set; }

        public static List<City> GetCities () {
            List<City> cities = new List<City> () {
                new City {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 1000000,
                    Province = "British Columbia"
                },
                new City {
                    CityId = 2,
                    CityName = "Surrey",
                    Population = 500000,
                    Province = "British Columbia"
                },
                new City {
                    CityId = 3,
                    CityName = "Calgary",
                    Population = 850000,
                    Province = "Alberta"
                },
                new City {
                    CityId = 4,
                    CityName = "Ottawa",
                    Population = 2000000,
                    Province = "Ontario"
                },
                new City {
                    CityId = 5,
                    CityName = "Saskatoon",
                    Population = 253000,
                    Province = "Sasktchewan"
                }
            };
            return cities;
        }
    }   
}