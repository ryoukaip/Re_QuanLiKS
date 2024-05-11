namespace Re_QuanLiKS
{
    partial class MaintenanceStatus
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
            this.button_SetAvailable = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_SetCleaning = new System.Windows.Forms.Button();
            this.button_SetOccupied = new System.Windows.Forms.Button();
            this.button_SetRepairing = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SetAvailable
            // 
            this.button_SetAvailable.Location = new System.Drawing.Point(222, 13);
            this.button_SetAvailable.Name = "button_SetAvailable";
            this.button_SetAvailable.Size = new System.Drawing.Size(104, 57);
            this.button_SetAvailable.TabIndex = 1;
            this.button_SetAvailable.Text = "Set Available";
            this.button_SetAvailable.UseVisualStyleBackColor = true;
            this.button_SetAvailable.Click += new System.EventHandler(this.button_SetAvailable_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(13, 264);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(313, 57);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_SetCleaning
            // 
            this.button_SetCleaning.Location = new System.Drawing.Point(222, 76);
            this.button_SetCleaning.Name = "button_SetCleaning";
            this.button_SetCleaning.Size = new System.Drawing.Size(104, 57);
            this.button_SetCleaning.TabIndex = 1;
            this.button_SetCleaning.Text = "Set Cleaning";
            this.button_SetCleaning.UseVisualStyleBackColor = true;
            this.button_SetCleaning.Click += new System.EventHandler(this.button_SetCleaning_Click);
            // 
            // button_SetOccupied
            // 
            this.button_SetOccupied.Location = new System.Drawing.Point(222, 138);
            this.button_SetOccupied.Name = "button_SetOccupied";
            this.button_SetOccupied.Size = new System.Drawing.Size(104, 57);
            this.button_SetOccupied.TabIndex = 1;
            this.button_SetOccupied.Text = "Set Occupied";
            this.button_SetOccupied.UseVisualStyleBackColor = true;
            this.button_SetOccupied.Click += new System.EventHandler(this.button_SetOccupied_Click);
            // 
            // button_SetRepairing
            // 
            this.button_SetRepairing.Location = new System.Drawing.Point(222, 201);
            this.button_SetRepairing.Name = "button_SetRepairing";
            this.button_SetRepairing.Size = new System.Drawing.Size(104, 57);
            this.button_SetRepairing.TabIndex = 1;
            this.button_SetRepairing.Text = "Set Repairing";
            this.button_SetRepairing.UseVisualStyleBackColor = true;
            this.button_SetRepairing.Click += new System.EventHandler(this.button_SetRepairing_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(203, 245);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaintenanceStatus
            // 
            this.AcceptButton = this.button_Cancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_SetRepairing);
            this.Controls.Add(this.button_SetOccupied);
            this.Controls.Add(this.button_SetCleaning);
            this.Controls.Add(this.button_SetAvailable);
            this.Name = "MaintenanceStatus";
            this.Text = "MaintananceStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaintenanceStatus_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_SetAvailable;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_SetCleaning;
        private System.Windows.Forms.Button button_SetOccupied;
        private System.Windows.Forms.Button button_SetRepairing;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}