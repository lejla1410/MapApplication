using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MapApplication.Models
{
    [Table("AtractionDB")]
    public class AtractionDb
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string AtractionName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        [StringLength(50)]
        public string City { get; set; }
        [StringLength(150)]
        public string Decription { get; set; }
        public string MyImagesFile { get; set; }
        public virtual City CityData { get; set; }
    }
}
