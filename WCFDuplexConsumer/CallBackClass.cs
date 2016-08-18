using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFDuplexConsumer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class CallBackClass:ServiceReference1.IService1Callback
    {
         string ServiceReference1.IService1Callback.CallBackGetString(string value)
        {
            
            // Program.client.GetString(value);
            return "ServiceReference1.IService1Callback.CallBackGetString " + value;
        }
    }
}
