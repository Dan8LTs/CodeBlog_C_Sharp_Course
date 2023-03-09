using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClientTCP
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
            //Console.WriteLine("take message");

            //var message = Console.ReadLine();
            //var data = Encoding.UTF8.GetBytes(message);
            //tcpSocket.Connect(tcpEndPoint);
            //tcpSocket.Send(data);

            //var buffer = new byte[256];
            //var size = 0;
            //var answer = new StringBuilder();

            //do
            //{
            //    size = tcpSocket.Receive(buffer);
            //    answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            //}
            //while (tcpSocket.Available > 0);

            //Console.WriteLine(answer.ToString());
            //tcpSocket.Shutdown(SocketShutdown.Both);
            //tcpSocket.Close();
            #endregion

            const string ip = "127.0.0.1";
            const int port = 8087;
            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);

            while (true)
            {
                Console.WriteLine("take your message");
                var message = Console.ReadLine();
                var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8086);
                udpSocket.SendTo(Encoding.UTF8.GetBytes(message), udpEndPoint);
                
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8086);
                do
                {
                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);
                Console.WriteLine(data);
                Console.ReadLine();
            }
            
        }
    }
}
