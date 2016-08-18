using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is server");
            UdpClient udpClient = new UdpClient();
            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //IPEndPoint groupEP = new IPEndPoint(IPAddress.Parse("10.168.197.122"), Port);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, Port);
            udpClient.Client.Bind(groupEP);
            try
            {
                while (true)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Waiting for broadcast");
                    byte[] bytes = udpClient.Receive(ref groupEP);

                    Console.WriteLine("Received broadcast from {0} :\n {1}\n",
                        groupEP.ToString(),
                        Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                    byte[] reply = Encoding.ASCII.GetBytes("Reply to Ping");
                    udpClient.Send(reply, reply.Length, groupEP); // reply back
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                udpClient.Close();
            }
            Console.Read();
        }

        private const int Port = 22112;
    }
}
