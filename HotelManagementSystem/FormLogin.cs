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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //DataAccess ds = new DataAccess();
                //string sql = "select * from UserInfo where ID='" + txtId.Text + "' and password ='"+txtId.Text+"';";

                //ds.ExecuteQueryTable(sql);

                //if (ds.Ds.Tables[0].Rows.Count == 1)
                //{
                //    MessageBox.Show("Valid Login");

                //    string sqlDashboard = "select * from UserInfo where Role ='admin' and ID='" + txtId.Text + "';";

                //    ds.ExecuteQueryTable(sqlDashboard);

                //    if (ds.Ds.Tables[0].Rows.Count == 1)
                //    {
                //        FormAdmin admin = new FormAdmin();
                //        admin.Show();
                //        this.Hide();
                //    }

                //    else
                //    {
                //        Receptionist emp = new Receptionist();
                //        emp.Show();
                //        this.Hide();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Invlid Login");
                //}

                string sql = "select * from LogIn where UserId = '" + txtId.Text + "' and Password ='" + txtPassword.Text + "';";



                DataAccess d = new DataAccess();
                d.ExecuteQueryTable(sql);


                if (d.Ds.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("Successful Login.\nWelcome, " + txtId.Text);

                    string sqlDashboard = "select * from UserInfo where Role ='Admin' and ID = '" + txtId.Text + "';";
                    d.ExecuteQueryTable(sqlDashboard);



                    if (d.Ds.Tables[0].Rows.Count == 1)
                    {
                        FormAdmin admin = new FormAdmin();
                        admin.Show();
                        this.Hide();
                    }

                    else
                    {
                        Receptionist emp = new Receptionist();
                        emp.Show();
                        this.Hide();
                    }

                    

                }
                else
                {
                    MessageBox.Show("Invalid User Id or Password.\nPlease Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnView_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
