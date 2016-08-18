using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WCFWebByteConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            webClient();
            //string URI = "http://localhost:59898/Service1.svc/getage?name=hi";
            //Byte[] byteArr = Encoding.ASCII.GetBytes("Hello");
            //using (WebClient client = new WebClient())
            //{
               
            //    client.Headers.Add("Content-Type","application/x-www-form-urlencoded");
            //    Byte[] byteArr = Encoding.ASCII.GetBytes("Hello");
            //    Byte[] result = client.UploadData("http://localhost:59898/Service1.svc/GetName","POST", byteArr);
            //    string resultString = Encoding.ASCII.GetString(result);
            //    Console.WriteLine(resultString);
            //    Console.ReadLine();
            //}
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:59898/Service1.svc/GetName");
            //request.Method = "POST";
            //request.GetRequestStream().Write(byteArr,0,byteArr.Length);
            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //{
            //    string date = response.Headers[HttpResponseHeader.Date];
            //    string contentType = response.Headers["content-type"];
            //}
        }
        public static void webClient()
        {

            Byte[] byteArr = Encoding.ASCII.GetBytes("Hello");
            using (WebClient client = new WebClient())
            {

                client.Headers.Add("Content-Type", "application/xml");
                client.Encoding = Encoding.UTF8;
                Byte[] result = client.UploadData("http://localhost:59898/Service1.svc/GetName", "POST", byteArr);
                string resultString = Encoding.ASCII.GetString(result);
                Console.WriteLine(resultString);
                Console.ReadLine();
            }

        }
        public static void httpWebRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:59898/Service1.svc/GetByte");
            request.ContentType = "application/xml";
            request.Method = "POST";
            request.KeepAlive = true;

            using (Stream requestStream = request.GetRequestStream())
            {
                var bytes = Encoding.UTF8.GetBytes("Test");
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();
            var abc = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(abc);
            Console.ReadLine();
        }
    }
}
