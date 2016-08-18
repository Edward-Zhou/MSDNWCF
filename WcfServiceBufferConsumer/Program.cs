using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfServiceBufferConsumer.ServiceReference1;

namespace WcfServiceBufferConsumer
{
    public class Program
    {
        public async Task getDate()
        { 
            //ViewModel vm = new ViewModel();
            //await vm.GetDateTime();            
        }
        static void Main(string[] args)
        {
            ViewModel vm = new ViewModel();
            //vm.GetDateTime();
            //Task.WaitAll(new Task[]{
            //    vm.getDateTime()
            //});
            vm.GetDateTime();
            while (true)
            {
                //change vm.currentDateTime to your own value like this.ViewModel.CurrentDateTime
                if (vm.currentDateTime != DateTime.MinValue)
                {
                    break;
                }
            }
            Console.WriteLine(vm.currentDateTime.ToString());
            Console.WriteLine("Main" + Thread.CurrentThread.ManagedThreadId);
            //Socket socket = new Socket(AddressFamily.InterNetwork,
            //        SocketType.Dgram, ProtocolType.Udp);
            //socket.EnableBroadcast = true;
            //socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //socket.Bind(new IPEndPoint(IPAddress.Any, Port));

            //EndPoint ipEndPoint = new IPEndPoint(IPAddress.Broadcast, Port);
            //byte[] data = Encoding.ASCII.GetBytes("Ping");
            //socket.SendTo(data, data.Length, SocketFlags.None, ipEndPoint);
            //while (true)
            //{
            //    data = new byte[1024];
            //    int received = socket.ReceiveFrom(data, ref ipEndPoint);

            //    Console.WriteLine(Encoding.ASCII.GetString(data, 0, received));
            //}

            //Service1Client client = new Service1Client();
            //Stream stream = File.OpenRead(@"D:\Edward\Project\MSDNWCF\WcfServiceBuffer\Client.docx");
            //client.UploadFile(stream);
            //Console.WriteLine("Upload is ok");
            Console.ReadLine();
        }
        private const int Port = 22112;

    }
}
