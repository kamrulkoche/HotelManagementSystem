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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new HotelManagementSystem.User_Controls.UcAddRoom());
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new HotelManagementSystem.User_Controls.UcEmployeeInfo());
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            log.Show();
            this.Hide();
        }
    }
}
