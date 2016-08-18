using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDuplex
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract=typeof(IService1CallBack))]
    public interface IService1
    {

        [OperationContract]
        [WebGet]
        string GetData(int value);
        [OperationContract]
        [WebGet]
        string GetString(string value);

    }
    public interface IService1CallBack
    {
        [OperationContract]
        string CallBackGetString(string value);
    }
}
