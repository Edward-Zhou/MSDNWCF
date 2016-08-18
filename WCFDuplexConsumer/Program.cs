using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDuplexConsumer.ServiceReference1;

namespace WCFDuplexConsumer
{
    public class Program
    {
        public static Service1Client client;
        public static void Main(string[] args)
        {
            CallBackClass callback = new CallBackClass();
            InstanceContext context = new InstanceContext(callback);
            client = new Service1Client(context);
            string result=client.GetData(123);
        }
    }
}
