using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTimeoutConsumer.ServiceReference3;

namespace WcfTimeoutConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTest test = new AsyncTest();
            test.GetCity();
            //GetCity();
            //Service1Client client = new Service1Client();
            ////client.InnerChannel.OperationTimeout = new TimeSpan(00,00,03);
            //try
            //{
            //    string result = client.GetData(DateTime.Now);
            //    Console.WriteLine(result);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //Console.WriteLine("test");

            Console.ReadLine();
        }
    }
    public class AsyncTest
    {
            public void GetCity()
        {
            Service1Client client = new Service1Client();
            client.GetCurrentDateTimeCompleted += client_GetCurrentDateTimeCompleted;
            client.GetCurrentDateTimeAsync();
            //await Task.WaitAll(() => {new Task(){client.GetCurrentDateTimeAsync() }});

        }
            public void GetNum()
        {
            Service1Client client = new Service1Client();
            client.GetDataCompleted += client_GetDataCompleted;
            client.GetDataAsync(13);


        }

        void client_GetDataCompleted(object sender, GetDataCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("client_GetDataCompleted");
        }

        void client_GetCurrentDateTimeCompleted(object sender, GetCurrentDateTimeCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("client_GetCurrentDateTimeCompleted");
            GetNum();

        }

    }
}
