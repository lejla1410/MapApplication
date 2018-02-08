using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MapApplication.Models
{
    public class City
    {
        public int Id { get; set; }
        [DisplayName("Miasto")]
        public string Name { get; set; }
        [DisplayName("Szerokość geograficzna miasta")]
        public double CityLatitude { get; set; }
        [DisplayName("Długość geograficzna miasta")]
        public double CityLongitude { get; set; }
        public virtual ICollection <AtractionDb> AtractionDb { get; set; }
    }
}