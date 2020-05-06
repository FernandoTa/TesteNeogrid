using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Api2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Api2.svc or Service_Api2.svc.cs at the Solution Explorer and start debugging.
    public class Service_Api2 : IService_Api2
    {
        public string calculaJuros(decimal inicial, int meses)
        {
            WebRequest request = WebRequest.Create("http://localhost:8080/taxaJuros");
            float juros = 0;
            string result = (inicial * (decimal)Math.Pow(1 + juros, meses)).ToString();
            int pos = result.IndexOf('.');
            result = result.Substring(0,pos+2);
            throw new NotImplementedException();
        }

        public string showMeTheCode()
        {
            throw new NotImplementedException();
        }
    }
}
