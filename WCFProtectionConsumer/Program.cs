using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFProtectionConsumer.ServiceReference2;

namespace WCFProtectionConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("NetTcpBinding_IService1");
            client.ClientCredentials.UserName.UserName = "v-tazho";
            client.ClientCredentials.UserName.Password = "Edward0701";
            client.DoWork();
            Console.WriteLine("Do Work is ok");
            Console.ReadLine();
        }
    }
}
