using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YikYakDotNet;
using YikYakDotNet.Statistics;
using YikYakDotNetMVC.Models;

namespace YikYakDotNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            double latitude = 44.93914;
            double longitude = -93.168503;
            string peekId = "100288";

            string messageID = "R/544eb4bd599dada380d88f1748d94";
            LocationPoint knownLocation = new LocationPoint(latitude, longitude);

            YikYakAPI api = new YikYakAPI();

            //try
            //{
            List<Yak> res = api.GetYaks(latitude, longitude);

            //Console.WriteLine(string.Format("Total Results: {0}", res.Count()));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //PeekMessages(latitude, longitude, peekId);

            //PeekAnywhere(latitude, longitude, latitude, longitude);


            return View(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}