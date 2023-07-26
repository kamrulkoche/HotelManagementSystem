using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            ucCheckInl1 a = new ucCheckInl1();
            addUserControl(a);
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            log.Show();
            this.Hide();
        }
    }
}
