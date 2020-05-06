using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteNeogrid.Models;

namespace TesteNeogrid.Controllers
{
    public class taxaJurosController : ApiController
    {
        public float getJuros()
        {
            Uri baseAddress = new Uri("http://localhost:8000/HelloService");
            string address = "http://localhost:8000/HelloService/MyService";

            using (ServiceHost serviceHost = new ServiceHost(typeof(HelloService), baseAddress))
            {
                serviceHost.AddServiceEndpoint(typeof(IHello), new BasicHttpBinding(), address);
                serviceHost.Open();
                Console.WriteLine("Press <enter> to terminate service");
                Console.ReadLine();
                serviceHost.Close();
            }
            Juros juros = new Juros();
            juros.juros = 0.01F;
            return juros.juros;
        }
    }
}
