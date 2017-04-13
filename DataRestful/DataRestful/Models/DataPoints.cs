using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataRestful.Models
{
    public class DataPoints
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string stationID { get; set; }
        public string csv { get; set; }
        public string json { get; set; }
    }
}