using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFInternetIntrantConsumer.ServiceReference2;


namespace WCFInternetIntrantConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("WSHttpBinding_IService1");
            client.ClientCredentials.UserName.UserName = "v-tazho";
            client.ClientCredentials.UserName.Password = "Edward0701";
            string result=client.GetData(123);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
