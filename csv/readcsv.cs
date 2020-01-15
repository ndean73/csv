﻿using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Collections.Generic;
using System.IO;
using ReadWriteLib;

namespace csv
{
    public class readcsv
    {

        // public static void Main()
        // {

        //   var path = "c://csvfiles//worldcities.csv";
        //  var recordList = ReadInCSV(path);
        //object c = City.FullName;
        // var recordList2 = ReadLib.ReadInCSV(path,(object) City.FullName);

        // }


        

        public static List<City> ReadInCSV(string absolutePath, object c)
        {
           
            List<City> result = new List<City>();
            using (var reader = new StreamReader(absolutePath))
            {
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.TypeConverterCache.AddConverter(typeof(double), new EmptyDouble());
                    csv.Configuration.RegisterClassMap<CityMap>();
                    //csv.Configuration.RegisterClassMap<CityMap>;

                    while (csv.Read())
                    {
                        result.Add(csv.GetRecord<City>());
                    }
                }
                return result;
            }
        }
      
    }
    public interface icity {

        public string Fullname(string a);
    }
    public class City:icity
    {
        private dynamic result;
        City c = new City();
        public string Fullname(string a) {

            var path = "c://csvfiles//worldcities.csv";
            result =csv.readcsv.ReadInCSV(path,c);
            return result;
        }

       // public static string FullName {
       //     get { return typeof(City).FullName;}
       // }
        public string City_name { get; set; }
        public string City_ascii { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Country { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public string Admin_name { get; set; }
        public string Capital { get; set; }
        public double Population { get; set; }
        public float Id { get; set; }
    }

    public sealed class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            AutoMap();
            Map(m => m.City_name).Name("city");
            Map(m => m.City_ascii).Name("city_ascii");
            Map(m => m.Admin_name).Name("admin_name");
            Map(m => m.Capital).Name("capital");
            Map(m => m.Country).Name("country");
            Map(m => m.Id).Name("id");
            Map(m => m.ISO2).Name("iso2");
            Map(m => m.ISO3).Name("iso3");
            Map(m => m.Lat).Name("lat");
            Map(m => m.Lng).Name("lng");
            Map(m => m.Population).Name("population");
        }
    }
    public class EmptyDouble : DoubleConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (text == "")
            {
                double value = 0;
                return value;
            } else
            {
                double value = System.Convert.ToDouble(text);
                return value;
            }
        }
    }
}