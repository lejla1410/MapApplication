using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapApplication.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CityLatitude { get; set; }
        public double CityLongitude { get; set; }
        public virtual ICollection <AtractionDb> AtractionDb { get; set; }
    }
}