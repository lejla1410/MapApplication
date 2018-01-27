using MapApplication.Models;
using MapApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapApplication.Controllers
{
    public class HomeController : Controller
    {
        private MapContext db = new MapContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MapView()
        {
            var markeryZbazdy = db.AtractionDb.ToList().Where(m => m.CityData.Equals("Id"));

            var markery = new List<AtractionDb>
            {
             new AtractionDb()
             {
                 AtractionName = "Muzeum Emigracji",
                 ID=8,
                 Latitude=54.5331021,
                 Longitude = 18.54793821,
                 City = "Gdynia",
                 Decription="Muzeum historyczne w Gdyni, samorządowa instytucja kultury Gdyni,"+
                 "założone w lutym 2012, udostępnione publiczności 16 maja 2015. Placówka dokumentuje historię emigracji Polaków.",
                 MyImagesFile= "MuzeumEmigracji.jpg"
             }
        };

            return View(new MapsViewModel(markery));
        }

        [HttpPost]
        public ActionResult MapView(string searchCityName)
        {
            var markeryZbazdy = db.AtractionDb.Where(m => m.City.ToLower().Equals(searchCityName)).ToList();

            return View(new MapsViewModel(markeryZbazdy));
        }

    }
}