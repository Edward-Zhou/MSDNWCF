using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCertificateConsumer.ServiceReference1;

namespace WCFCertificateConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            string result= client.GetData(123);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
