﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace socket__client
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TCP

            //const string ip = "127.0.0.1";
            //const int port = 8080;

            //var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //tcpSocket.Bind(tcpEndPoint);
            //tcpSocket.Listen(5);

            //while(true)
            //{
            //    var listener = tcpSocket.Accept();
            //    var buffer = new byte[256];
            //    var size = 0;
            //    var data = new StringBuilder();

            //    do
            //    {
            //        size = listener.Receive(buffer);
            //        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
            //    }
            //    while(listener.Available > 0);
            //    Console.WriteLine(data);

            //    listener.Send(Encoding.UTF8.GetBytes("Success"));
            //    listener.Shutdown(SocketShutdown.Both);
            //    listener.Close();
            #endregion

            const string ip = "127.0.0.1";
            const int port = 8086;
            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);

            while (true)
            {
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();

                // адрес клиента
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);

                do
                {
                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);
                udpSocket.SendTo(Encoding.UTF8.GetBytes("message shipped"), udpEndPoint);
                Console.WriteLine(data);
            }
        }
    }

}
