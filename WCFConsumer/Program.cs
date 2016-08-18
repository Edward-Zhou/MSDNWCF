using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFConsumer.ServiceReference1;
using WCFConsumer.ServiceReference2;

namespace WCFConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference2.Service1Client client = new ServiceReference2.Service1Client(new InstanceContext(new ICallBack()));
            //client.GetDataAsync(123);
            //client.GetDataCompleted += client_GetDataCompleted;
            //Console.WriteLine(client.GetData(123));
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
            string result=client.GetCertificate("localhost");
            //CallWcf();
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static async void CallWcf()
        {
            string serviceURL = @"http://localhost:50201/Service1.svc";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceURL + "/getData?value=123");
            using (var response = (HttpWebResponse)await httpWebRequest.GetResponseAsync())
            {
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                HttpWebRequest httpWebRequestResponse = (HttpWebRequest)WebRequest.Create(serviceURL + "/getReturn?value=" + responseFromServer);
                HttpWebResponse r=(HttpWebResponse)await httpWebRequestResponse.GetResponseAsync();
                Stream dataStream2 = r.GetResponseStream();                    
                // Open the stream using a StreamReader for easy access.
                StreamReader reader2 = new StreamReader(dataStream2);
                // Read the content.
                string responseFromServer2 = reader2.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer2);

                Console.WriteLine(httpWebRequestResponse.GetResponse());
            }
            
        }
        public static void CallFromWCFWebClient()
        {


        }
        static void client_GetDataCompleted(object sender, GetDataCompletedEventArgs e)
        {
            string result = e.Result.ToString();
        }
        //public class ICallBack : WCFConsumer.ServiceReference2.IService1Callback
        //{
        //    void WCFConsumer.ServiceReference2.IService1Callback.GetStringIsReady(string value)
        //    {
        //        Console.WriteLine("hello word at client");
        //    }
        //}
    }
}
