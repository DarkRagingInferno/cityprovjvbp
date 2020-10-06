using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace SportsPlus.Models
{
    public class Province
    {
        [Key]
        [Display (Name ="Province Abbreviation")]
        public string ProvinceCode { get; set; }
        [Display (Name ="Province Name")]
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }

        public static List<Province> GetProvinces ()  {
           

            List<Province> provinces = new List<Province> () {
                new Province {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                new Province {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",
                },
                new Province {
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchewan",
                },
                new Province {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                },
            };
            return provinces;
        }
        public void createCities(){
        }
    }
}