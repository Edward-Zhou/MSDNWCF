using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFFaultExceptionConsumer.ServiceReference1;

namespace WCFFaultExceptionConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            try
            {
                client.Didide(1,0);
            }
            catch (Exception e)
            {                
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
