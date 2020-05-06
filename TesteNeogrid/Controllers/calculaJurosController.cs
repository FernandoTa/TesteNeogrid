using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TesteNeogrid.Controllers
{
    public class calculaJurosController : ApiController
    {
        public float Calculajuros(float ValorInicial, float juros, int Meses)
        {
            return (float)(ValorInicial * Math.Pow((1 + juros), Meses));
        }
    }
}
