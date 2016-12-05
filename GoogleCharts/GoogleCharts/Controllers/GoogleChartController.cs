using GoogleCharts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleChartsControllers
{
    public class GoogleChartController : Controller
    {
        // GET: GoogleChart
        public ActionResult Column()
        {
            return View();
        }
        [HttpGet]

        public ActionResult GetSalesData()
        {
            List<SalesData> sd = new List<SalesData>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                sd = db.SalesData.OrderBy(a => a.Year).ToList();
            }
            var chartData = new object[sd.Count + 1];
            chartData[0] = new object[] {
                "Year",
                "Electronics",
                "Book And Media",
                "Home And Kitchen"
            };
            int j = 0;
            foreach (var i in sd)
            {
                j++;
                chartData[j] = new object[] {
                    i.Year,i.Electronics,i.BookAndMedia,i.HomeAndKitchen
                };
            }
          
           
           return new JsonResult { Data=chartData,JsonRequestBehavior=JsonRequestBehavior.AllowGet};
        }

        [HttpGet]
        public ActionResult GetSalesData1()
        {
            List<SalesData> sd = new List<SalesData>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                sd = db.SalesData.OrderBy(a => a.Year).ToList();
            }
            var chartData1 = new object[sd.Count + 1];
            chartData1[0] = new object[] {
                "Year",
                "Electronics",
                "Book And Media",
                //"Home And Kitchen"
            };
            int j = 0;
            foreach (var i in sd)
            {
                j++;
                chartData1[j] = new object[] {
                    i.Year,i.Electronics,i.BookAndMedia/*,i.HomeAndKitchen*/
                };
            }


            return new JsonResult { Data = chartData1, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult LineChart()
        {
            return View();
        }
        public ActionResult TwoChart()
        {
            return View();
        }
    }
}