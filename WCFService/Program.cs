using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService.ServiceReference1;
using WcfServiceLibrary;
namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            client.GetData(123);
            //ServiceHost host = new ServiceHost("WCFTCPService");
            //host.Open();
            Console.WriteLine("service open");
            Console.ReadLine();
        }
    }

}
