using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Nazwa atrakcji")]
        [StringLength(50)]
        public string AtractionName { get; set; }
        [DisplayName("Szerokość geograficzna")]
        public double Latitude { get; set; }
        [DisplayName("Długość geograficzna")]
        public double Longitude { get; set; }

        [StringLength(50)]
        [DisplayName("Nazwa miasta")]
        public string City { get; set; }
        [StringLength(150)]
        [DisplayName("Opis atrakcji")]
        public string Decription { get; set; }
        [DisplayName("Zdjęcie atrakcji")]
        public string MyImagesFile { get; set; }
        public virtual City CityData { get; set; }
    }
}
