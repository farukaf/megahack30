using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ButekoGOAPP.Models
{
    public class Map
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Position Position { get { return new Position(Latitude, Longitude); } }
        public string Description { get; set; }
    }
}
