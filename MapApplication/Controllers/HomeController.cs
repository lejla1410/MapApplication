﻿using MapApplication.Models;
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
        private MapsDBContext1 db = new MapsDBContext1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MapView()
        {
            //var markeryZbazdy = db.AtractionDb.ToList().Where(m => m.CityData).Equals("Id");

            var markery = new List<AtractionDb>
            {
             new AtractionDb()
             {
                 AtractionName = "Muzeum Emigracji",
                 ID=8,
                 Latitude=54.5331021,
                 Longitude = 18.54793821,
                 City = "Gdynia"
             }
            };

            return View(new MapsViewModel(markery));
        }

    }
}