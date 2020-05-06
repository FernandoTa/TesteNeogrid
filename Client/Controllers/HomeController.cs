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
            ViewBag.Message = client.taxaJuros();

            return new EmptyResult();
        }

        public ActionResult calculaJuros(decimal inicial, int meses)
        {
            ViewBag.Message = client1.calculaJuros(inicial, meses);

            return View();
        }
    }
}