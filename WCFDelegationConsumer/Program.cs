using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDelegationConsumer.ServiceReference2;

namespace WCFDelegationConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("WSHttpBinding_IService11");
            
            //client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Identification;
            string result = client.GetData(123);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
