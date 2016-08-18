using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFTCPServiceProvider;

namespace WCFTCPServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.Service1));
            host.Open();
            Console.WriteLine("service tcp is open");
            Console.ReadLine();
        }
    }
}
