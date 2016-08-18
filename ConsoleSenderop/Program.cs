using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConsoleSenderop
{
    class Program
    {
        static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
                ProtocolType.Udp);
       
        static void Main(string[] args)
        {
            s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            s.Bind(new IPEndPoint(IPAddress.Any, Port));
            Thread t = new Thread(StartListener);
            t.Start();
            // Give thread time to start listening
            Thread.Sleep(1000);
            IPAddress broadcast = IPAddress.Parse("10.168.173.132");
            byte[] sendbuf = Encoding.ASCII.GetBytes("Ping");
            IPEndPoint ep = new IPEndPoint(broadcast, Port);
            s.SendTo(sendbuf, ep);      
            Console.WriteLine("Message sent to the broadcast address");
        }

        private const int Port = 22112;
        private static void StartListener()
        {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast");                    
                    EndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, Port);
                    var data = new byte[1024];
                    int received = s.ReceiveFrom(data, ref ipEndPoint);

                    Console.WriteLine("Received broadcast from {0} :\n {1}\n",
                        ipEndPoint.ToString(),
                        Encoding.ASCII.GetString(data, 0, data.Length));
                }

            }

        }

        //static void Main(string[] args)
        //{
        //    Thread t = new Thread(StartListener);
        //    t.Start();
        //    // Give thread time to start listening
        //    Thread.Sleep(1000);

        //    //Console.ReadLine();

        //    //var client = new UdpClient();
        //    //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 22112);
        //    //client.Connect(ep);
        //    //byte[] sendbuf = Encoding.ASCII.GetBytes("Ping");
        //    //client.Send(sendbuf, sendbuf.Length);
        //    //var receivedData = client.Receive(ref ep);
        //    //Console.Write("receive data from " + ep.ToString() + " " + Encoding.ASCII.GetString(receivedData, 0, receivedData.Length));

        //    using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
        //        ProtocolType.Udp))
        //    {
        //        s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

        //        IPAddress broadcast = IPAddress.Parse("10.168.197.122");
        //        byte[] sendbuf = Encoding.ASCII.GetBytes("Ping");
        //        IPEndPoint ep = new IPEndPoint(broadcast, Port);
        //        s.SendTo(sendbuf, ep);
        //        byte[] bytes = new byte[256];
        //        var receivedData = s.Receive(bytes);
        //        var result = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
        //        Console.Write("receive data from " + ep.ToString() + " " + result);
        //    }

        //    Console.WriteLine("Message sent to the broadcast address");
        //    Console.ReadLine();
        //}

        //private const int Port = 22112;

        //private static void StartListener()
        //{
        //    UdpClient udpClient = new UdpClient(Port);
        //    IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, Port);

        //    try
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("Waiting for broadcast");
        //            byte[] bytes = udpClient.Receive(ref groupEP);

        //            Console.WriteLine("Received broadcast from {0} :\n {1}\n",
        //                groupEP.ToString(),
        //                Encoding.ASCII.GetString(bytes, 0, bytes.Length));
        //            byte[] reply = Encoding.ASCII.GetBytes("Reply to Ping");
        //            //udpClient.Send(reply, reply.Length, groupEP); // reply back
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //    finally
        //    {
        //       udpClient.Close();
        //    }
        //}
    }


