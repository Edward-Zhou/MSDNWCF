using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAsyncConsumer.ServiceReference1;

namespace WCFAsyncConsumer
{
    class Program
    {
        static void Main(string[] args)
        {


            Service1Client client = new Service1Client();
            client.GetDataCompleted -= client_GetDataCompleted;
            client.GetDataCompleted += client_GetDataCompleted;
            client.GetDataAsync(123);
            Console.ReadLine();
        }



        static void client_GetDataCompleted(object sender, GetDataCompletedEventArgs e)
        {
           
                if (e.Error == null && e.Result != null)
                {
                    Console.WriteLine("result "+e.Result.ToString());
                }
                Debug.WriteLine("result " + e.Result.ToString());
            
        }
    }
}
