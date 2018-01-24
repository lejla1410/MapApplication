using MapApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapApplication.ViewModel
{
    public class MapsViewModel
    {
        public IEnumerable<MapsDB> Markery { get; set; }

        public MapsViewModel(IEnumerable<MapsDB> markery)
        {
            Markery = markery;
        }
    }
}