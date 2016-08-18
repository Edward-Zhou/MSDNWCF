using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDuplex
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class Service1 : IService1
    {

        IService1CallBack Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IService1CallBack>();
            }
        }

        string IService1.GetData(int value)
        {
            string result="firest request is " + value;
            Callback.CallBackGetString(result);
            return result;
        }

        string IService1.GetString(string value)
        {
            return "second request is " + value;
        }
    } 
}
