
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsPlus.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Display (Name ="City Name")]
        public string CityName { get; set; }
        [Display (Name ="City Population")]
        public int Population { get; set; }
        public string ProvinceCode { get; set; }
        public Province Province  { get; set; }

        public static List<City> GetCities () {
            List<City> cities = new List<City> () {
                new City {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 1000000,
                    ProvinceCode = "BC"
                },
                new City {
                    CityId = 2,
                    CityName = "Surrey",
                    Population = 700000,
                    ProvinceCode = "BC"
                },
                new City {
                    CityId = 3,
                    CityName = "Burnaby",
                    Population = 60000,
                    ProvinceCode = "BC"
                },
                new City {
                    CityId = 4,
                    CityName = "Calgary",
                    Population = 850000,
                    ProvinceCode = "AB"
                },
                new City {
                    CityId = 5,
                    CityName = "Edmonton",
                    Population = 500000,
                    ProvinceCode = "AB"
                },
                new City {
                    CityId = 6,
                    CityName = "Red Deer",
                    Population = 75000,
                    ProvinceCode = "AB"
                },
                new City {
                    CityId = 7,
                    CityName = "Ottawa",
                    Population = 2000000,
                    ProvinceCode = "ON"
                },
                new City {
                    CityId = 8,
                    CityName = "Windsor",
                    Population = 350000,
                    ProvinceCode = "ON"
                },
                new City {
                    CityId = 9,
                    CityName = "Toronto",
                    Population = 900000,
                    ProvinceCode = "ON"
                },
                new City {
                    CityId = 10,
                    CityName = "Saskatoon",
                    Population = 253000,
                    ProvinceCode = "SK"
                },
                new City {
                    CityId = 11,
                    CityName = "Regina",
                    Population = 117000,
                    ProvinceCode = "SK"
                },
                new City {
                    CityId = 12,
                    CityName = "Melford",
                    Population = 128000,
                    ProvinceCode = "SK"
                }
            };
            return cities;
        }
    }   
}