using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Api2" in both code and config file together.
    [ServiceContract]
    public interface IService_Api2
    {
        [OperationContract]
        string calculaJuros(decimal inicial, int meses);
        [OperationContract]
        string showMeTheCode();
    }
}
