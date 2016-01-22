using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(4444);
            Socket client_sock;
            listener.Start();

            while (true)
            {
                try
                {
                    client_sock = listener.AcceptSocket();
                }
                catch
                {
                    return;
                }
                ClientHandler client_handler = new ClientHandler(client_sock);
                client_handler.Start();
            }
        }
    }
}
