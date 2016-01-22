using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Owner
{
    public partial class frmComputerSelect : Form
    {
        public frmComputerSelect(List<string> computer_list)
        {
            InitializeComponent();

            foreach (string s in computer_list)
            {
                string ip_address;
                try
                {
                    ip_address = "(" + LocalNetWork.GetIPByHostName(s) + ")";
                }
                catch
                {
                    ip_address = "(not found)";
                }
                cbComputers.Items.Add(s + " " + ip_address);
            }
            if (cbComputers.Items.Count > 0)
            {
                cbComputers.SelectedIndex = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbComputers.SelectedIndex < 0)
            {
                MessageBox.Show("Вы не выбрали компьютер", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            using (Form proccess_inf_form = new frmProccessInfo(cbComputers.SelectedItem.ToString()))
            {
                proccess_inf_form.ShowDialog();
            }
            this.Show();
        }
    }
}