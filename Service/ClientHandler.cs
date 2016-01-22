using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;

namespace Service
{
    class ClientHandler
    {
        Thread thread;
        Socket client_sock;

        public ClientHandler(Socket client_sock)
        {
            this.client_sock = client_sock;
            thread = new Thread(Run);
        }

        public void Start()
        {
            thread.Start();
        }

        private void Run()
        {
            int lenght_data = 0;
            byte[] client_data = new byte[256];
            while (true)
            {
                try
                {
                    lenght_data = client_sock.Receive(client_data);
                }
                catch
                {

                }

               /* try
                {
                    if (lenght_data > 0)
                    { }
                }*/
               }
        }
    }
}
