using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Owner
{
    public partial class frmComputerSelect : Form
    {
        public frmComputerSelect(List<string> computer_list)
        {
            InitializeComponent();
          
            foreach (string s in computer_list)
            {
                cbComputers.Items.Add(s + " (" + LocalNetWork.GetIPByHostName(s) + ")");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
