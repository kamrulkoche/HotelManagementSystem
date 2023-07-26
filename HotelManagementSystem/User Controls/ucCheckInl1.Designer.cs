namespace HotelManagementSystem
{
    partial class ucCheckInl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.NID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutoSearchType = new System.Windows.Forms.TextBox();
            this.txtAutoSearchAvailability = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtAutoNIDSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.AllowUserToAddRows = false;
            this.dgvCustomerInfo.AllowUserToDeleteRows = false;
            this.dgvCustomerInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NID,
            this.Name,
            this.CheckInDate,
            this.CheckOutDate,
            this.RoomNo});
            this.dgvCustomerInfo.Location = new System.Drawing.Point(0, 45);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.ReadOnly = true;
            this.dgvCustomerInfo.RowHeadersWidth = 51;
            this.dgvCustomerInfo.RowTemplate.Height = 24;
            this.dgvCustomerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(1312, 124);
            this.dgvCustomerInfo.TabIndex = 0;
            this.dgvCustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerInfo_CellClick);
            // 
            // NID
            // 
            this.NID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NID.DataPropertyName = "NID";
            this.NID.HeaderText = "NID";
            this.NID.MinimumWidth = 6;
            this.NID.Name = "NID";
            this.NID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckInDate.DataPropertyName = "CheckInDate";
            this.CheckInDate.HeaderText = "Check In ";
            this.CheckInDate.MinimumWidth = 6;
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckOutDate.DataPropertyName = "CheckOutDate";
            this.CheckOutDate.HeaderText = "Check Out";
            this.CheckOutDate.MinimumWidth = 6;
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "Room no";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNID.Location = new System.Drawing.Point(26, 182);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(39, 20);
            this.lblNID.TabIndex = 1;
            this.lblNID.Text = "NID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room no";
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(30, 205);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(304, 22);
            this.txtNID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 270);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 22);
            this.txtName.TabIndex = 7;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(29, 338);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(304, 22);
            this.dtpCheckIn.TabIndex = 8;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(29, 412);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(304, 22);
            this.txtRoomNo.TabIndex = 9;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Indigo;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(29, 455);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(147, 57);
            this.btnCheckIn.TabIndex = 10;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToDeleteRows = false;
            this.dgvRoomInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvRoomInfo.Location = new System.Drawing.Point(514, 229);
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.ReadOnly = true;
            this.dgvRoomInfo.RowHeadersWidth = 51;
            this.dgvRoomInfo.RowTemplate.Height = 24;
            this.dgvRoomInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomInfo.Size = new System.Drawing.Size(798, 283);
            this.dgvRoomInfo.TabIndex = 11;
            this.dgvRoomInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomInfo_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "roomNo";
            this.Column1.HeaderText = "Room no";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "roomType";
            this.Column2.HeaderText = "Room type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bed";
            this.Column3.HeaderText = "Bed";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "price";
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "available";
            this.Column5.HeaderText = "Available";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(510, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Room Information";
            // 
            // txtAutoSearchType
            // 
            this.txtAutoSearchType.Location = new System.Drawing.Point(711, 198);
            this.txtAutoSearchType.Name = "txtAutoSearchType";
            this.txtAutoSearchType.Size = new System.Drawing.Size(208, 22);
            this.txtAutoSearchType.TabIndex = 14;
            this.txtAutoSearchType.TextChanged += new System.EventHandler(this.txtAutoSearchType_TextChanged);
            // 
            // txtAutoSearchAvailability
            // 
            this.txtAutoSearchAvailability.Location = new System.Drawing.Point(1081, 199);
            this.txtAutoSearchAvailability.Name = "txtAutoSearchAvailability";
            this.txtAutoSearchAvailability.Size = new System.Drawing.Size(208, 22);
            this.txtAutoSearchAvailability.TabIndex = 15;
            this.txtAutoSearchAvailability.TextChanged += new System.EventHandler(this.txtAutoSearchAvailability_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search by type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1078, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search by availability";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Indigo;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(211, 455);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(147, 57);
            this.btnCheckOut.TabIndex = 18;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtAutoNIDSearch
            // 
            this.txtAutoNIDSearch.Location = new System.Drawing.Point(1057, 17);
            this.txtAutoNIDSearch.Name = "txtAutoNIDSearch";
            this.txtAutoNIDSearch.Size = new System.Drawing.Size(252, 22);
            this.txtAutoNIDSearch.TabIndex = 19;
            this.txtAutoNIDSearch.TextChanged += new System.EventHandler(this.txtAutoNIDSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(954, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search by NID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Click On Room Information";
            // 
            // ucCheckInl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAutoNIDSearch);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutoSearchAvailability);
            this.Controls.Add(this.txtAutoSearchType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoomInfo);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNID);
            this.Controls.Add(this.dgvCustomerInfo);
           // this.Name = "ucCheckInl1";
            this.Size = new System.Drawing.Size(1312, 539);
            this.Load += new System.EventHandler(this.ucCheckInl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutoSearchType;
        private System.Windows.Forms.TextBox txtAutoSearchAvailability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtAutoNIDSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
