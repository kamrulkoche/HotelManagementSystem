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
    public partial class UcAddRoom : UserControl
    {
        private DataAccess Da {get; set;}
        public UcAddRoom()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoRoomNoGenerate();
        }

        private void PopulateGridView(string sql = "select * from rooms;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvRoomDetails.AutoGenerateColumns = false;
            this.dgvRoomDetails.DataSource = ds.Tables[0];
        }

        private bool IsValidToSave()
        {
            if(String.IsNullOrEmpty(this.txtRoomNo.Text) || String.IsNullOrEmpty(this.cmbRoomType.Text) ||
                String.IsNullOrEmpty(this.cmbBed.Text) || String.IsNullOrEmpty(this.txtRoomPrice.Text) ||
                String.IsNullOrEmpty(this.cmbAvailable.Text))
             return true;
            else return false;
            
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave()==true)
                {
                    MessageBox.Show("Please fill the all required field");
                    return;
                }
                   
                string sql = @"insert into rooms (roomNo, roomType, bed, price, available) values
                        ('" + txtRoomNo.Text + "', '" + cmbRoomType.Text + "', '" + cmbBed.Text + "', " +
                        "'" + txtRoomPrice.Text + "', '" + cmbAvailable.Text + "')";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Room added successfully");
                }
                else
                    MessageBox.Show("Failed to add room");
                this.PopulateGridView();
                this.ClearContent();
                this.AutoRoomNoGenerate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
        }
        private void txtAutoRoomSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from rooms where roomType like'"+this.txtAutoRoomSearch.Text+"%';";
            this.PopulateGridView(sql);
        }

        private void ClearContent()
        {
            this.txtRoomNo.Clear();
            this.txtRoomPrice.Clear();
            this.cmbRoomType.SelectedIndex = -1;
            this.cmbBed.SelectedIndex = -1;
            this.cmbAvailable.SelectedIndex = -1;
            this.txtAutoRoomSearch.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try 
            {
                this.ClearContent();
                this.AutoRoomNoGenerate();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidToDelete()
        {
            /*var q = "select available from rooms where availablity = 'No';";
            var 
            var dt = this.Da.ExecuteQueryTable(q);
            var availability = dt.Rows[0][0].ToString();*/
            
            if(this.cmbAvailable.SelectedIndex==1)
                return true;
            else
            {
                return false;
            }
        }
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.IsValidToDelete()==true)
                {
                    MessageBox.Show("Cannot delete the room at this moment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       return;
                }    
                if (this.dgvRoomDetails.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var id = this.dgvRoomDetails.CurrentRow.Cells[0].Value.ToString();
                DialogResult d = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    return;
                var sql = "delete from rooms where roomNo = '" + id + "'";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Room deleted successfully");
                }
                else
                    MessageBox.Show("Failed to delete room");
                this.PopulateGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
        }

        private void UcAddRoom_Load(object sender, EventArgs e)
        {
            this.dgvRoomDetails.ClearSelection();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsValidToSave()==true)
                {
                    MessageBox.Show("Please fill all required field");
                    return;
                }

             
                var query = "select * from rooms where roomNo='" + this.txtRoomNo.Text + "'";
                var dt=this.Da.ExecuteQueryTable(query);

                if(dt.Rows.Count == 1)
                {
                    var sql = @"update rooms
                            set roomType='" + this.cmbRoomType.Text + @"',
                            bed='" + this.cmbBed.Text + @"',
                            price='" + this.txtRoomPrice.Text + @"',
                           available='" + this.cmbAvailable.Text + @"'
                         where roomNo='" + this.txtRoomNo.Text + "';";
                        
                         

                    int count = this.Da.ExecuteDMLQuery(sql);
                    if(count == 1)
                    {
                        MessageBox.Show("Room updated properly");
                        
                    }
                    else
                    {
                        MessageBox.Show("Room updatation failed");
                    }
                       
                }

                this.PopulateGridView();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }

            
        }
        
        private void dgvRoomDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtRoomNo.Text = this.dgvRoomDetails.SelectedRows[0].Cells[0].Value.ToString();
            this.cmbRoomType.Text = this.dgvRoomDetails.SelectedRows[0].Cells[1].Value.ToString();
            this.cmbBed.Text = this.dgvRoomDetails.SelectedRows[0].Cells[2].Value.ToString();
            this.txtRoomPrice.Text = this.dgvRoomDetails.SelectedRows[0].Cells[3].Value.ToString();
            this.cmbAvailable.Text = this.dgvRoomDetails.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AutoRoomNoGenerate()
        {
            var q = "select roomNo from rooms order by roomNo desc;";
            var dt = this.Da.ExecuteQueryTable(q);
            var lastRoomNo = dt.Rows[0][0].ToString();
            string[] s = lastRoomNo.Split();
            int temp = Convert.ToInt32(s[0]);
            string newId = (++temp).ToString("d3");
            //string newId = (++temp).ToString("d2");
            this.txtRoomNo.Text = newId;
            //MessageBox.Show(newId);
        }
    }
}
