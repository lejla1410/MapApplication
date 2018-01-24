using MapApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapApplication.ViewModel
{
    public class MapsViewModel
    {
        public IEnumerable<AtractionDb> Markery { get; set; }

        public MapsViewModel(IEnumerable<AtractionDb> markery)
        {
            Markery = markery;
        }
    }
}