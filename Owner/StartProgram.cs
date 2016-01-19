using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Owner
{
    public partial class frmStartProgram : Form
    {
        public frmStartProgram()
        {
            InitializeComponent();
        }

        private void StartProgram_Load(object sender, EventArgs e)
        {
            List<string> host_list = LocalNetWork.GetServerList();
            List<string> available_host_list = new List<string>();

            if (host_list.Count() <= 1)
            {
                MessageBox.Show("В локальной сети не обнаружено ни одного компьютера", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            string my_host_name = Dns.GetHostName();
            host_list.Remove(my_host_name);
            const int port = 44444;
            const byte ENQ = 0x05;
            const byte ACK = 0x06;

            for (int i = 0; i < host_list.Count(); i++)
            {
                string host = host_list.ElementAt(i);

                using (TcpClient client = new TcpClient(AddressFamily.InterNetwork))
                {
                    try
                    {
                        client.Connect(host, port);
                        NetworkStream stream = client.GetStream();
                        byte[] buffer = new byte[256];
                        int byte_read;
                        List<byte> response = new List<byte>();

                        stream.WriteByte(ENQ);

                        do
                        {
                            byte_read = stream.Read(buffer, 0, buffer.Length);
                            for (int j = 0; j < byte_read; j++)
                            {
                                response.Add(buffer[j]);
                            }

                        } while (stream.DataAvailable);

                        if (response.Count > 0 && response[0] == ACK)
                        {
                            available_host_list.Add(host);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }

                pbStatus.Value = (i + 1) / (host_list.Count());
            }

            if (available_host_list.Count() <= 0)
            {
                MessageBox.Show("В локальной сети не обнаружено ни одного компьютера", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            this.Close();
            Form computer_select_form = new frmComputerSelect(available_host_list);
            computer_select_form.Show();
        }
    }
}
