using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFNETTCPConsumer.ServiceReference1;

namespace WCFNETTCPConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            client.DoWork();
            Console.WriteLine("client DoWork is run");
            Console.ReadLine();
        }
    }
}
