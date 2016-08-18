using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFNamedPipeConsumer.ServiceReference1;

namespace WCFNamedPipeConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "net.pipe://vdi-v-tazho.fareast.corp.microsoft.com/WCFNamedPipe/Service1.svc";
            for (int i = 0; i < 1; i++)
            {
                ChannelFactory<IService1> factory = new ChannelFactory<IService1>(new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), new EndpointAddress(baseAddress));
                //IService1 channel = factory.CreateChannel();
                
                Service1Client channel = new Service1Client("NetNamedPipeBinding_IService1");
                
                //string result = channel.GetData(i);
                //Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
