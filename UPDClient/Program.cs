using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UPDClient
{
    class Program
    {
        private const int Port = 22112;

        static void Main(string[] args)
        {
            Console.WriteLine("this is client");
            // This constructor arbitrarily assigns the local port number.
            UdpClient udpClient = new UdpClient();
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Parse("10.168.173.132"), Port);
            byte[] request = Encoding.ASCII.GetBytes("Ping");
            udpClient.Send(request, request.Length, groupEP); 
            while (true)
            {
                groupEP = new IPEndPoint(IPAddress.Any, Port);
                var data = new byte[1024];
                byte[] bytes = udpClient.Receive(ref groupEP);
                Console.WriteLine("Received broadcast from {0} :\n {1}\n",
                    groupEP.ToString(),
                    Encoding.ASCII.GetString(bytes, 0, bytes.Length));

            }


        }
    }
}
