using Owner.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Owner
{
    public partial class frmProccessInfo : Form
    {
        private string computer_name;
        public frmProccessInfo(string computer_name)
        {
            InitializeComponent();

            dtpDateTimeFrom.Value = DateTime.Now.Date;
            this.computer_name = computer_name;
            this.Text = computer_name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            const int PORT = 44444;
            using (TcpClient client = new TcpClient(AddressFamily.InterNetwork))
            {
                try
                {
                    client.Connect(computer_name, PORT);
                    NetworkStream stream = client.GetStream();

                    ICommand com = new GetProccessCommand().SetDateTimeFrom(dtpDateTimeFrom.Value)
                                                           .SetDateTimeTo(dtpDateTimeTo.Value);
                    stream.Write(com.GetBuffer(), 0, com.GetBuffer().Length);

                    byte[] buffer = new byte[256];
                    int byte_read;
                    List<byte> response = new List<byte>();
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
            
            dgvProccesTable.Rows.Add(new string[] { "12345", "notepad++", "5 февраля", "16 января" });
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            const int NAME_INDEX = 1;
            if (dgvProccesTable.Rows.Count <= 0)
            {
                return;
            }

            if (tbFilter.Text == string.Empty)
            {
                foreach (DataGridViewRow row in dgvProccesTable.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvProccesTable.Rows)
                {
                    row.Visible = row.Cells[NAME_INDEX].Value.ToString().IndexOf(tbFilter.Text) >= 0;
                }
            }
        }
    }
}
