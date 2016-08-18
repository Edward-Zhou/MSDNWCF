using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WcfProductRESTServiceConsumer.ServiceReference1;

namespace WcfProductRESTServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string serviceURL = @"http://localhost:44641/Service1.svc";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceURL + "/getData?value=123");
            WebResponse httpWebResponse = httpWebRequest.GetResponse();
            //Service1Client client = new Service1Client();
            //string result=client.GetData(123);
            //Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
