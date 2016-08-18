using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFByteConsumer.ServiceReference1;

namespace WCFByteConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            Byte[] byteArr = client.GetByte(Encoding.ASCII.GetBytes( "World"));
            Console.WriteLine(Encoding.ASCII.GetString(byteArr));
            Console.ReadLine();
        }
    }
}
