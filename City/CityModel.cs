using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Cities
{

    public interface ICityModel
    {
        public CityModel AddCities();
    }
       
    public class CityModel : ICityModel
    {
        public CityModel AddCities() {

            var db = DBConn.conn();
            return null;
        }
        public string City_name { get; set; }
        public string City_ascii { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Admin_name { get; set; }
        public string Capital { get; set; }
        public double Population { get; set; }
        public int CountryId { get; set; }
    }

    
}