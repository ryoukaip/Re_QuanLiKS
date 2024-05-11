namespace Re_QuanLiKS
{
    partial class MainInterface
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_AddNewRoom = new System.Windows.Forms.Button();
            this.button_EditRoom = new System.Windows.Forms.Button();
            this.button_ChangeRoom = new System.Windows.Forms.Button();
            this.button_RoomCheckout = new System.Windows.Forms.Button();
            this.button_RoomReport = new System.Windows.Forms.Button();
            this.button_MaintanenceStatus = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_MainenanceRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(840, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_AddNewRoom
            // 
            this.button_AddNewRoom.Location = new System.Drawing.Point(858, 13);
            this.button_AddNewRoom.Name = "button_AddNewRoom";
            this.button_AddNewRoom.Size = new System.Drawing.Size(148, 46);
            this.button_AddNewRoom.TabIndex = 1;
            this.button_AddNewRoom.Text = "Add New Room";
            this.button_AddNewRoom.UseVisualStyleBackColor = true;
            this.button_AddNewRoom.Click += new System.EventHandler(this.button_AddNewRoom_Click);
            // 
            // button_EditRoom
            // 
            this.button_EditRoom.Location = new System.Drawing.Point(858, 65);
            this.button_EditRoom.Name = "button_EditRoom";
            this.button_EditRoom.Size = new System.Drawing.Size(148, 46);
            this.button_EditRoom.TabIndex = 1;
            this.button_EditRoom.Text = "Edit Room";
            this.button_EditRoom.UseVisualStyleBackColor = true;
            this.button_EditRoom.Click += new System.EventHandler(this.button_EditRoom_Click);
            // 
            // button_ChangeRoom
            // 
            this.button_ChangeRoom.Location = new System.Drawing.Point(858, 117);
            this.button_ChangeRoom.Name = "button_ChangeRoom";
            this.button_ChangeRoom.Size = new System.Drawing.Size(148, 46);
            this.button_ChangeRoom.TabIndex = 1;
            this.button_ChangeRoom.Text = "Change Room";
            this.button_ChangeRoom.UseVisualStyleBackColor = true;
            this.button_ChangeRoom.Click += new System.EventHandler(this.button_ChangeRoom_Click);
            // 
            // button_RoomCheckout
            // 
            this.button_RoomCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_RoomCheckout.Location = new System.Drawing.Point(858, 325);
            this.button_RoomCheckout.Name = "button_RoomCheckout";
            this.button_RoomCheckout.Size = new System.Drawing.Size(148, 46);
            this.button_RoomCheckout.TabIndex = 1;
            this.button_RoomCheckout.Text = "Room Checkout";
            this.button_RoomCheckout.UseVisualStyleBackColor = true;
            this.button_RoomCheckout.Click += new System.EventHandler(this.button_RoomCheckout_Click);
            // 
            // button_RoomReport
            // 
            this.button_RoomReport.Location = new System.Drawing.Point(856, 169);
            this.button_RoomReport.Name = "button_RoomReport";
            this.button_RoomReport.Size = new System.Drawing.Size(148, 46);
            this.button_RoomReport.TabIndex = 1;
            this.button_RoomReport.Text = "Room Report";
            this.button_RoomReport.UseVisualStyleBackColor = true;
            this.button_RoomReport.Click += new System.EventHandler(this.button_RoomReport_Click);
            // 
            // button_MaintanenceStatus
            // 
            this.button_MaintanenceStatus.Location = new System.Drawing.Point(856, 273);
            this.button_MaintanenceStatus.Name = "button_MaintanenceStatus";
            this.button_MaintanenceStatus.Size = new System.Drawing.Size(148, 46);
            this.button_MaintanenceStatus.TabIndex = 1;
            this.button_MaintanenceStatus.Text = "Maintanance Status";
            this.button_MaintanenceStatus.UseVisualStyleBackColor = true;
            this.button_MaintanenceStatus.Click += new System.EventHandler(this.button_MaintanenceStatus_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(858, 433);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(148, 46);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_MainenanceRequest
            // 
            this.button_MainenanceRequest.Location = new System.Drawing.Point(858, 221);
            this.button_MainenanceRequest.Name = "button_MainenanceRequest";
            this.button_MainenanceRequest.Size = new System.Drawing.Size(148, 46);
            this.button_MainenanceRequest.TabIndex = 1;
            this.button_MainenanceRequest.Text = "Maintanance Request";
            this.button_MainenanceRequest.UseVisualStyleBackColor = true;
            this.button_MainenanceRequest.Click += new System.EventHandler(this.button_MainenanceRequest_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 491);
            this.Controls.Add(this.button_MainenanceRequest);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_MaintanenceStatus);
            this.Controls.Add(this.button_RoomReport);
            this.Controls.Add(this.button_RoomCheckout);
            this.Controls.Add(this.button_ChangeRoom);
            this.Controls.Add(this.button_EditRoom);
            this.Controls.Add(this.button_AddNewRoom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_AddNewRoom;
        private System.Windows.Forms.Button button_EditRoom;
        private System.Windows.Forms.Button button_ChangeRoom;
        private System.Windows.Forms.Button button_RoomCheckout;
        private System.Windows.Forms.Button button_RoomReport;
        private System.Windows.Forms.Button button_MaintanenceStatus;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_MainenanceRequest;
    }
}