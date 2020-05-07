using Client.Models;
using Client.Service_api1;
using Client.Service_api2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        ServiceClient client = new ServiceClient();//(endpointConfigurationName:"taxaJuros");
        Service_Api2Client client1 = new Service_Api2Client(endpointConfigurationName: "calculajuros");
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult taxaJuros()
        {
            ViewBag.Message = client.taxaJuros()*100;

            return View();
        }

        [HttpGet]
        public ActionResult calculaJuros(decimal inicial, int meses)
        {
            //ViewBag.Message = client1.calculaJuros(decimal.Parse(inicial.ToString()), meses);
            float juros = client1.calculaJuros();
            string result = (inicial * (decimal)Math.Pow(1 + juros, meses)).ToString();
            int pos = result.IndexOf(',');
            if (pos == -1)
            {
                result = result + ",00";
                pos = result.IndexOf(',');
            }
            ViewBag.Message = result.Substring(0, pos + 3);
            return View();
        }
        [HttpGet]
        public ActionResult showMeTheCode()
        {
            ViewBag.Message = client1.showMeTheCode().ToString();

            return View();
        }
    }
}