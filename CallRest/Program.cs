using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CallRest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        public static async void Test()
        {
            var serialized = "{\"userName\":\"UName\",\"password\":\"Pwd\"}";
            var httpClient = new HttpClient();
            var request = new StringContent(serialized, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:13560/Service1.svc/valid/test", request);
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}
