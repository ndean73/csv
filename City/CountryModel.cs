using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cities
{ 
    public interface ICountryModel
   {
    public IList<T> AddCountries<T>(IEnumerable<T> countryCapitalQuery);
   }
    public class CountryModel : ICountryModel
    {

        public IList<T> AddCountries<T>(IEnumerable<T> countryCapitalQuery)
        {

            var db = DBConn.conn();
            return null;
        }       
        public string Name { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
    }
}
