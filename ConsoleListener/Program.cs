using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ConsoleListener
{
    class Program
    {
        private const int listenPort = 11000;

        private static void StartListener()
        {
            bool done = false;

            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                while (!done)
                {
                    Console.WriteLine("Waiting for broadcast");
                    byte[] bytes = listener.Receive(ref groupEP);

                    Console.WriteLine("Received broadcast from {0} :\n {1}\n",
                        groupEP.ToString(),
                        Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
    ProtocolType.Udp);

                    IPAddress broadcast = IPAddress.Parse("10.168.197.122");

                    byte[] sendbuf = Encoding.ASCII.GetBytes("get message");
                    IPEndPoint ep = new IPEndPoint(broadcast, 11000);

                    s.SendTo(sendbuf, ep);

                    Console.WriteLine("reply");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }

        public static int Main()
        {
            StartListener();

            return 0;
        }

    }
}
