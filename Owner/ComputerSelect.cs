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
        public frmComputerSelect()
        {
            InitializeComponent();

            IEnumerable<string> list = LocalNetWork.GetServerList();

            foreach (string s in list)
            {
                cbComputers.Items.Add(LocalNetWork.GetIPByHostName(s));
            }
        }
    }
}
