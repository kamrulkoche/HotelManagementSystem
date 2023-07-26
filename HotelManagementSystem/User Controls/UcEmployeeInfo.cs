using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.User_Controls
{
    public partial class UcEmployeeInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public UcEmployeeInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        //    this.PopulateGridView2();
            this.AutoIdGenerate();

        }

        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvEmployeeInfo.AutoGenerateColumns = false;
            this.dgvEmployeeInfo.DataSource = ds.Tables[0];
        }
        private void PopulateGridView2(string sql = "select * from Login;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvEmployeeInfo.AutoGenerateColumns = false;
            this.dgvEmployeeInfo.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.cmbRole.SelectedIndex = -1;
            this.txtMobile.Clear();
            this.txtAddress.Clear();
            this.txtSalary.Clear();
            this.txtAutoEmployeeSearch.Clear();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.cmbRole.Text) || String.IsNullOrEmpty(this.cmbGender.Text) ||
                String.IsNullOrEmpty(this.txtMobile.Text) || String.IsNullOrEmpty(this.txtAddress.Text) ||
                String.IsNullOrEmpty(this.txtSalary.Text))
                return true;
            else return false;
        }

        private void txtAutoEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Gender like'" + this.txtAutoEmployeeSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void AutoIdGenerate()
        {
            var q = "select ID from UserInfo order by ID desc;";
            var dt = this.Da.ExecuteQueryTable(q);
            var lastRoomNo = dt.Rows[0][0].ToString();
            string[] s = lastRoomNo.Split();
            int temp = Convert.ToInt32(s[0]);
            string newId = (++temp).ToString("d4");
            //string newId = (++temp).ToString("d2");
            this.txtID.Text = newId;
            //MessageBox.Show(newId);
        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtID.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[0].Value.ToString();
                this.txtName.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[1].Value.ToString();
                //this.txtPassword.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[2].Value.ToString();
                this.cmbRole.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[2].Value.ToString();
                this.dtpDOB.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[3].Value.ToString();
                this.cmbGender.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[4].Value.ToString();
                this.txtMobile.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[5].Value.ToString();
                this.txtAddress.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[6].Value.ToString();
                this.txtSalary.Text = this.dgvEmployeeInfo.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave() == true)
                {
                    MessageBox.Show("Please fill all the required fileds!");
                    return;
                }

                string sql1 = @"insert into UserInfo (ID, Name, Role, DOB, Gender, Mobile, Address, Salary) values
                        ('" + txtID.Text + "', '" + txtName.Text + "', '" + cmbRole.Text + "', '" + dtpDOB.Value + "',  '"+cmbGender.Text+"' , '" + txtMobile.Text + "', '" + txtAddress.Text + "', '" + txtSalary.Text + "')";
                string sql2 = @"insert into LogIn (UserId, Password) values('" + txtID.Text + "', '" + txtPassword.Text + "')";

                var count1 = this.Da.ExecuteDMLQuery(sql1);
                var count2 = this.Da.ExecuteDMLQuery(sql2);
                if (count1 == 1 && count2 == 1)
                {
                    MessageBox.Show("Employee added successfully");
                }
                else
                    MessageBox.Show("Failed to add Employee");
                this.PopulateGridView();
                this.ClearContent();
                this.AutoIdGenerate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (IsValidToSave() == true)
                {
                    MessageBox.Show("Please fill all required field");
                    return;
                }


                var query = "select * from UserInfo where ID = '" + this.txtID.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql1 = @"update UserInfo
                            set Name='" + this.txtName.Text + @"',
                            Role='" + this.cmbRole.Text + @"',
                            DOB='" + this.dtpDOB.Value + @"',
                            Gender='" + this.cmbGender.Text + @"',
                            Address='" + this.txtAddress.Text + @"',
                            Mobile='" + this.txtMobile.Text + @"',
                            Salary='" + this.txtSalary.Text + @"'
                            where ID='" + this.txtID.Text + "';";

                    var sql2 = @"update LogIn
                                set Password = '" + this.txtPassword.Text + @"'
                                where UserId ='" + this.txtID.Text + "';";


                    int count1 = this.Da.ExecuteDMLQuery(sql1);
                    int count2 = this.Da.ExecuteDMLQuery(sql2);
                    if (count1 == 1 && count2 == 1)
                    {
                        MessageBox.Show("Employee information updated properly");

                    }
                    else
                    {
                        MessageBox.Show("Employee information updatation failed");
                    }

                }

                this.PopulateGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            this.ClearContent();
            this.AutoIdGenerate();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployeeInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var id = this.dgvEmployeeInfo.CurrentRow.Cells[0].Value.ToString();
                DialogResult d = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    return;
                var sql1 = "delete from UserInfo where ID = '" + id + "'";
                var sql2 = "delete from LogIn where UserId = '" + id + "';";
                var count1 = this.Da.ExecuteDMLQuery(sql1);
                var count2 = this.Da.ExecuteDMLQuery(sql2);
                if (count1 == 1 && count2 == 1)
                {
                    MessageBox.Show("Employee deleted successfully");
                }
                else
                    MessageBox.Show("Failed to delete Employee");
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
        }

        private void UcEmployeeInfo_Load(object sender, EventArgs e)
        {
            this.dgvEmployeeInfo.ClearSelection();
        }

        private void txtAutoEmployeeSearch_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Role like'" + this.txtAutoEmployeeSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
