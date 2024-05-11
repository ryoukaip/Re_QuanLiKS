namespace Re_QuanLiKS
{
    partial class MaintenanceRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RoomID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Reason = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Request = new System.Windows.Forms.Button();
            this.button_make_available = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance Request:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room ID:";
            // 
            // textBox_RoomID
            // 
            this.textBox_RoomID.Location = new System.Drawing.Point(91, 51);
            this.textBox_RoomID.Name = "textBox_RoomID";
            this.textBox_RoomID.Size = new System.Drawing.Size(205, 22);
            this.textBox_RoomID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reason:";
            // 
            // comboBox_Reason
            // 
            this.comboBox_Reason.FormattingEnabled = true;
            this.comboBox_Reason.Items.AddRange(new object[] {
            "Cleaning"});
            this.comboBox_Reason.Location = new System.Drawing.Point(91, 97);
            this.comboBox_Reason.Name = "comboBox_Reason";
            this.comboBox_Reason.Size = new System.Drawing.Size(205, 24);
            this.comboBox_Reason.TabIndex = 4;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(136, 133);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Request
            // 
            this.button_Request.Location = new System.Drawing.Point(221, 133);
            this.button_Request.Name = "button_Request";
            this.button_Request.Size = new System.Drawing.Size(75, 23);
            this.button_Request.TabIndex = 5;
            this.button_Request.Text = "Request";
            this.button_Request.UseVisualStyleBackColor = true;
            this.button_Request.Click += new System.EventHandler(this.button_Request_Click);
            // 
            // button_make_available
            // 
            this.button_make_available.Location = new System.Drawing.Point(15, 133);
            this.button_make_available.Name = "button_make_available";
            this.button_make_available.Size = new System.Drawing.Size(118, 23);
            this.button_make_available.TabIndex = 6;
            this.button_make_available.Text = "Make Available";
            this.button_make_available.UseVisualStyleBackColor = true;
            this.button_make_available.Visible = false;
            this.button_make_available.Click += new System.EventHandler(this.button_make_available_Click);
            // 
            // MaintenanceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 168);
            this.Controls.Add(this.button_make_available);
            this.Controls.Add(this.button_Request);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.comboBox_Reason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_RoomID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaintenanceRequest";
            this.Text = "MaintenanceRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RoomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Reason;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Request;
        private System.Windows.Forms.Button button_make_available;
    }
}