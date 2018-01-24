using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MapApplication.Models
{
    [Table("MapsDB")]
    public partial class MapsDB
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string AtractionName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [StringLength(50)]
        public string City { get; set; }
        public string MyImagesFile { get; set; }
        public virtual City CityData { get; set; }
    }
}
