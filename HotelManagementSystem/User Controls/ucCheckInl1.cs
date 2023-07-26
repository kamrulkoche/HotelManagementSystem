using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ucCheckInl1 : UserControl
    {
       
        private DataAccess Da { get; set; }

        public ucCheckInl1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.PopulateGridView();
            this.PopulateRoomGridView();
            this.PopulateCustomerGridView();    
        }
        private void PopulateRoomGridView(string sql = "select * from rooms;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvRoomInfo.AutoGenerateColumns = false;
            this.dgvRoomInfo.DataSource = ds.Tables[0];
        }
        private void PopulateCustomerGridView(string sql = "select * from Customer;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvCustomerInfo.AutoGenerateColumns = false;
            this.dgvCustomerInfo.DataSource = ds.Tables[0];
        }

        private bool IsValidToCheckIn()
        {
            //    /*var q = "select available from rooms where availablity = 'No';";
            //    var 
            //    var dt = this.Da.ExecuteQueryTable(q);
            //    var availability = dt.Rows[0][0].ToString();*/
             var avl1 = this.dgvRoomInfo.CurrentRow.Cells[4].Value.ToString();
            var avl2 = this.dgvCustomerInfo.CurrentRow.Cells[3].Value.ToString();
            if (avl1 == "No" || avl2==null)
                return true;
            else
                return false;
        
            
            
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
               if(this.IsValidToCheckIn()==true)
                {
                    MessageBox.Show("Room already booked");
                    return;
                }
              
                

                    string sql1 = @"insert into Customer (NID, Name, CheckInDate, RoomNo) values
                        ('" + txtNID.Text + "', '" + txtName.Text + "', '" + dtpCheckIn.Value + "','" + txtRoomNo.Text + "')";
                    string sql2 = "update rooms set available = 'No' where roomNo = '" + txtRoomNo.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql1);
                    var count1 = this.Da.ExecuteDMLQuery(sql2);

                    if (count == 1 && count1 == 1)
                    {
                        MessageBox.Show("CheckInSUccesssful");
                    }
                    else
                        MessageBox.Show("Check In failed");
                    this.PopulateRoomGridView();
                    this.PopulateCustomerGridView();
                    //this.ClearContent();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
        }

        private void txtAutoSearchAvailability_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from rooms where available like'" + this.txtAutoSearchAvailability.Text + "%';";
            this.PopulateRoomGridView(sql);
        }

        private void txtAutoSearchType_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from rooms where roomType like'" + this.txtAutoSearchType.Text + "%';";
            this.PopulateRoomGridView(sql);
        }

        private void txtAutoNIDSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Customer where NID like'" + this.txtAutoNIDSearch.Text + "%';";
            this.PopulateCustomerGridView(sql);
        }
       /* private int BillGenerate()
        {
            //var sql1 = this.dgvCustomerInfo.CurrentRow.Cells[2].Value.ToString();
            //var sql2 = this.dgvCustomerInfo.CurrentRow.Cells[3].Value.ToString();
            //string[] checkInDate = sql1.Split('-');
            //string[] checkOutDate = sql2.Split('-');
            //int d1 = Convert.ToInt32(checkInDate[0]);
            //int d2 = Convert.ToInt32(checkInDate[0]);
            //int duration = d1 - d2;
            //var price = this.dgvRoomInfo.CurrentRow.Cells[3].Value.ToString();
            //var p = int.Parse(price);
            //int bill = duration * p;
            //return bill;
        }*/
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try {
                string sql1 = @"update Customer set CheckOutDate = '" + dtpCheckIn.Value + "' where RoomNo = '"+txtRoomNo.Text+"';";
                       
                string sql2 = "update rooms set available = 'Yes' where roomNo =  '"+txtRoomNo.Text +"';";
                var count = this.Da.ExecuteDMLQuery(sql1);
                var count1 = this.Da.ExecuteDMLQuery(sql2);

                if (count == 1 && count1 == 1)
                {
                    MessageBox.Show("Check Out Successsful");
                }
                else
                    MessageBox.Show("Check Out failed");
                this.PopulateCustomerGridView();
                this.PopulateRoomGridView();
                //var bill = this.BillGenerate();
               // this.lblBill.Text = bill.ToString();
                //this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
}

        private void ucCheckInl1_Load(object sender, EventArgs e)
        {
            this.dgvRoomInfo.ClearSelection();
            this.dgvCustomerInfo.ClearSelection();
        }

        private void dgvRoomInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtRoomNo.Text = this.dgvRoomInfo.CurrentRow.Cells[0].Value.ToString();
        }

        /*private void dgvCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNID.Text = this.dgvCustomerInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvCustomerInfo.CurrentRow.Cells["Name"].Value.ToString();
        }*/

        private void dgvCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtNID.Text = this.dgvCustomerInfo.CurrentRow.Cells[0].Value.ToString();
                this.txtName.Text = this.dgvCustomerInfo.CurrentRow.Cells["Name"].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
