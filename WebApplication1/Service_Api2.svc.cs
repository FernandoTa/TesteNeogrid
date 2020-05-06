using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Api2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Api2.svc or Service_Api2.svc.cs at the Solution Explorer and start debugging.
    public class Service_Api2 : IService_Api2
    {
        ServiceClient client = new ServiceClient();
        public float calculaJuros()//(decimal inicial, int meses)
        {
            float juros = client.taxaJuros();
            //string result = (inicial * (decimal)Math.Pow(1 + juros, meses)).ToString();
            //int pos = result.IndexOf(',');
            //if(pos == -1)
            //{
            //    result = result+",00";
            //    pos = result.IndexOf(',');
            //}
            //result = result.Substring(0,pos+3);
            //return result
            return juros;
        }

        public string showMeTheCode()
        {
            string gitUrl = "https://github.com/FernandoTa/TesteNeogrid.git";
            return gitUrl;
        }
    }
}
