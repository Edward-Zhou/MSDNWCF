using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ListenerProcess
{
    class Program
    {
        private static Socket _myListenSocket;
        private static AutoResetEvent _myStopEvent = new AutoResetEvent(false);
        private static AutoResetEvent _myExitEvent = new AutoResetEvent(false);
        private static Process _myProcess;
        static void Main(string[] args)
        {
            Console.WriteLine("1:Starting");

            //_myProcess = new Process
            //{
            //    StartInfo =
            //    {
            //        //CreateNoWindow = true,
            //        UseShellExecute = false,
            //        FileName = @"D:\Edward\Project\MSDNWCF\ExecutorProcess\bin\Debug\ExecutorProcess.exe"
            //    }
            //};

            //_myProcess.Start();

            // create socket
            IPEndPoint aEndPoint;
            if (!Socket.OSSupportsIPv6)
            {
                _myListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                aEndPoint = new IPEndPoint(IPAddress.Any, 12345);
            }
            else
            {
                _myListenSocket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
                _myListenSocket.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, 0);
                aEndPoint = new IPEndPoint(IPAddress.IPv6Any, 12345);
            }

           

            _myListenSocket.Bind(aEndPoint);
            _myListenSocket.NoDelay = true;

            Thread aListeningThread = new Thread(StartListener, 1);
            aListeningThread.Name = string.Format("Listener thread for '{0}'", aEndPoint);
            aListeningThread.Start();
            _myProcess = new Process
            {
                StartInfo =
                {
                    //CreateNoWindow = true,
                    UseShellExecute = false,
                    FileName = @"D:\Edward\Project\MSDNWCF\ExecutorProcess\bin\Debug\ExecutorProcess.exe"
                }
            };

            _myProcess.Start();
            Console.WriteLine("1:Wait for stop event");
            _myStopEvent.WaitOne();
            Console.WriteLine("1:Stop event received");
            Console.WriteLine("1:Sleeping");
            Thread.Sleep(2000);
            Console.WriteLine("1:Closing socket");
            _myListenSocket.Close();
            Console.WriteLine("1:Wait for exit event");
            _myExitEvent.WaitOne();
            Console.WriteLine("1:Exit event received");

            Console.WriteLine("1:Exiting");
            //_myProcess = new Process
            //{
            //    StartInfo =
            //    {
            //        //CreateNoWindow = true,
            //        UseShellExecute = false,
            //        FileName = @"D:\Edward\Project\MSDNWCF\ExecutorProcess\bin\Debug\ExecutorProcess.exe"
            //    }
            //};

            //_myProcess.Start();
            if (!_myProcess.HasExited)
            {
                _myProcess.Kill();
            }
            Console.ReadLine();
        }

        private static void StartListener(object obj)
        {
            _myListenSocket.Listen(20);
            try
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Calling accept");
                        Socket aAcceptedSocket = _myListenSocket.Accept();
                        Console.WriteLine("2:Accepted socket with handle: {0}", aAcceptedSocket.Handle);

                        Console.WriteLine("2:Set the stop event");
                        _myStopEvent.Set();
                    }
                    catch (SocketException aSocketException)
                    {
                        Console.WriteLine("2:Got SocketException: {0} with error code: {1}", aSocketException.ToString(),
                            aSocketException.ErrorCode);
                        if (!_myListenSocket.IsBound)
                        {
                            Console.WriteLine("2:Closing socket");
                            _myListenSocket.Close();
                            throw;
                        }
                    }
                    finally
                    {
                        _myStopEvent.Set();
                    }
                }
            }
            catch (Exception aException)
            {
                Console.WriteLine("2:Got exception: {0}", aException.ToString());
                Console.WriteLine("2:Set the exit event");
                _myExitEvent.Set();
            }


        }

    }
}