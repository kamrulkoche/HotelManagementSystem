namespace HotelManagementSystem.User_Controls
{
    partial class UcAddRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRoomDetails = new System.Windows.Forms.DataGridView();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutoRoomSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbBed = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAvailable = new System.Windows.Forms.ComboBox();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlAddNewRoom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetails)).BeginInit();
            this.pnlAddNewRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room details                    ";
            // 
            // dgvRoomDetails
            // 
            this.dgvRoomDetails.AllowUserToAddRows = false;
            this.dgvRoomDetails.AllowUserToDeleteRows = false;
            this.dgvRoomDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNo,
            this.roomType,
            this.bed,
            this.price,
            this.available});
            this.dgvRoomDetails.Location = new System.Drawing.Point(25, 57);
            this.dgvRoomDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoomDetails.Name = "dgvRoomDetails";
            this.dgvRoomDetails.ReadOnly = true;
            this.dgvRoomDetails.RowHeadersWidth = 51;
            this.dgvRoomDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomDetails.Size = new System.Drawing.Size(679, 518);
            this.dgvRoomDetails.TabIndex = 1;
            this.dgvRoomDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomDetails_CellClick);
            // 
            // roomNo
            // 
            this.roomNo.DataPropertyName = "roomNo";
            this.roomNo.HeaderText = "Room number";
            this.roomNo.MinimumWidth = 6;
            this.roomNo.Name = "roomNo";
            this.roomNo.ReadOnly = true;
            this.roomNo.Width = 125;
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "roomType";
            this.roomType.HeaderText = "Type";
            this.roomType.MinimumWidth = 6;
            this.roomType.Name = "roomType";
            this.roomType.ReadOnly = true;
            this.roomType.Width = 125;
            // 
            // bed
            // 
            this.bed.DataPropertyName = "bed";
            this.bed.HeaderText = "Bed";
            this.bed.MinimumWidth = 6;
            this.bed.Name = "bed";
            this.bed.ReadOnly = true;
            this.bed.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // available
            // 
            this.available.DataPropertyName = "available";
            this.available.HeaderText = "Available";
            this.available.MinimumWidth = 6;
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.Width = 126;
            // 
            // txtAutoRoomSearch
            // 
            this.txtAutoRoomSearch.Location = new System.Drawing.Point(540, 26);
            this.txtAutoRoomSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutoRoomSearch.Name = "txtAutoRoomSearch";
            this.txtAutoRoomSearch.Size = new System.Drawing.Size(164, 22);
            this.txtAutoRoomSearch.TabIndex = 3;
            this.txtAutoRoomSearch.TextChanged += new System.EventHandler(this.txtAutoRoomSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Price";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomNo.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(29, 84);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(389, 39);
            this.txtRoomNo.TabIndex = 18;
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.Location = new System.Drawing.Point(29, 326);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(389, 39);
            this.txtRoomPrice.TabIndex = 19;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "AC",
            "Non AC"});
            this.cmbRoomType.Location = new System.Drawing.Point(29, 169);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(389, 40);
            this.cmbRoomType.TabIndex = 20;
            // 
            // cmbBed
            // 
            this.cmbBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBed.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBed.FormattingEnabled = true;
            this.cmbBed.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cmbBed.Location = new System.Drawing.Point(29, 240);
            this.cmbBed.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBed.Name = "cmbBed";
            this.cmbBed.Size = new System.Drawing.Size(389, 40);
            this.cmbBed.TabIndex = 21;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Indigo;
            this.btnAddRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(445, 84);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(97, 55);
            this.btnAddRoom.TabIndex = 22;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 381);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Available";
            // 
            // cmbAvailable
            // 
            this.cmbAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailable.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvailable.FormattingEnabled = true;
            this.cmbAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbAvailable.Location = new System.Drawing.Point(29, 408);
            this.cmbAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAvailable.Name = "cmbAvailable";
            this.cmbAvailable.Size = new System.Drawing.Size(389, 40);
            this.cmbAvailable.TabIndex = 24;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Indigo;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.Location = new System.Drawing.Point(445, 169);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(97, 55);
            this.btnUpdateRoom.TabIndex = 26;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Indigo;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(445, 240);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(97, 55);
            this.btnDeleteRoom.TabIndex = 27;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Indigo;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(445, 326);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 132);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlAddNewRoom
            // 
            this.pnlAddNewRoom.Controls.Add(this.btnClear);
            this.pnlAddNewRoom.Controls.Add(this.btnDeleteRoom);
            this.pnlAddNewRoom.Controls.Add(this.btnUpdateRoom);
            this.pnlAddNewRoom.Controls.Add(this.cmbAvailable);
            this.pnlAddNewRoom.Controls.Add(this.label6);
            this.pnlAddNewRoom.Controls.Add(this.btnAddRoom);
            this.pnlAddNewRoom.Controls.Add(this.cmbBed);
            this.pnlAddNewRoom.Controls.Add(this.cmbRoomType);
            this.pnlAddNewRoom.Controls.Add(this.txtRoomPrice);
            this.pnlAddNewRoom.Controls.Add(this.txtRoomNo);
            this.pnlAddNewRoom.Controls.Add(this.label5);
            this.pnlAddNewRoom.Controls.Add(this.label4);
            this.pnlAddNewRoom.Controls.Add(this.label3);
            this.pnlAddNewRoom.Controls.Add(this.label2);
            this.pnlAddNewRoom.Location = new System.Drawing.Point(729, 26);
            this.pnlAddNewRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddNewRoom.Name = "pnlAddNewRoom";
            this.pnlAddNewRoom.Size = new System.Drawing.Size(565, 462);
            this.pnlAddNewRoom.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Search1;
            this.pictureBox1.Location = new System.Drawing.Point(495, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UcAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAutoRoomSearch);
            this.Controls.Add(this.pnlAddNewRoom);
            this.Controls.Add(this.dgvRoomDetails);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcAddRoom";
            this.Size = new System.Drawing.Size(1313, 604);
            this.Load += new System.EventHandler(this.UcAddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetails)).EndInit();
            this.pnlAddNewRoom.ResumeLayout(false);
            this.pnlAddNewRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRoomDetails;
        private System.Windows.Forms.TextBox txtAutoRoomSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn bed;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbBed;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAvailable;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlAddNewRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
