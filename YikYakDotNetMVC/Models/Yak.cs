using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YikYakDotNetMVC.Models
{
    public class Yak
    {
        public string MessageID { get; set; }
        public string Message { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Time { get; set; }
    }
}