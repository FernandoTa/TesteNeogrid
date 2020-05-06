using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class valoresCalculo
    {
        [DisplayName("Capital inicial: ")]
        public float inicial { get; set; }

        [DisplayName("Tempo: ")]
        public int meses { get; set; }
    }
}