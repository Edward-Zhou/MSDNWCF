using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFMessageFormatterConsumer.ServiceReference1;

namespace WCFMessageFormatterConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
            {
                client.GetData(123);
                var headers = OperationContext.Current.IncomingMessageHeaders;
            }
        }
    }
}
