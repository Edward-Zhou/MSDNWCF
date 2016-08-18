using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DuplexAsync
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract()]
    public interface IService1
    {
        [OperationContract]
        void GetData(string data);

    }

    [ServiceContract]
    public interface IService1Notification
    { 
        [OperationContract(IsOneWay=true)]
        void GetDataIsReady(string data);
    }

}
