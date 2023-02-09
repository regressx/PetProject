using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using PetProject.CommonLogic;

namespace PetProject.TcpServer // Note: actual namespace depends on the project name.
{
    public class TcpServer
    {
        private readonly ILogWriter _logger;
        private Socket _listener;

        public TcpServer(ILogWriter logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _listener.Bind(new IPEndPoint(IPAddress.Any, 11111));
            _listener.Listen(10);

            while (true)
            {
                using var tcpClient = await _listener.AcceptAsync();
                var bytesRead = new byte[4];
                using FileStream fs = new FileStream("Копия на сервере.txt", FileMode.Create);
                
                while (true)
                {
                    var count = await tcpClient.ReceiveAsync(bytesRead);

                    if (bytesRead[count - 1] == '\0')
                    {
                        fs.Write(bytesRead, 0, count - 1);
                        break;
                    }
                        
                    fs.Write(bytesRead, 0, count);
                }

                await tcpClient.SendAsync(Encoding.UTF8.GetBytes("Success"));
            }
        }
    }
}