namespace Re_QuanLiKS
{
    partial class RoomCheckout
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
            this.label_CheckinDateTime = new System.Windows.Forms.Label();
            this.listView_Services = new System.Windows.Forms.ListView();
            this.columnHeader_Services = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Services_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Foods = new System.Windows.Forms.ListView();
            this.columnHeader_Foods = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Foods_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Drinks = new System.Windows.Forms.ListView();
            this.columnHeader_Drinks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Drinks_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Checkout = new System.Windows.Forms.Button();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_GuestName = new System.Windows.Forms.TextBox();
            this.textBox_RoomID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CheckoutDateTime = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_TotalPriceOfTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_CheckinDateTime
            // 
            this.label_CheckinDateTime.AutoSize = true;
            this.label_CheckinDateTime.Location = new System.Drawing.Point(88, 119);
            this.label_CheckinDateTime.Name = "label_CheckinDateTime";
            this.label_CheckinDateTime.Size = new System.Drawing.Size(150, 13);
            this.label_CheckinDateTime.TabIndex = 80;
            this.label_CheckinDateTime.Text = "CheckinDateTimePlaceHolder";
            // 
            // listView_Services
            // 
            this.listView_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Services,
            this.columnHeader_Services_Price});
            this.listView_Services.HideSelection = false;
            this.listView_Services.Location = new System.Drawing.Point(380, 199);
            this.listView_Services.Name = "listView_Services";
            this.listView_Services.Size = new System.Drawing.Size(169, 230);
            this.listView_Services.TabIndex = 79;
            this.listView_Services.UseCompatibleStateImageBehavior = false;
            this.listView_Services.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Services
            // 
            this.columnHeader_Services.Text = "Services";
            this.columnHeader_Services.Width = 71;
            // 
            // columnHeader_Services_Price
            // 
            this.columnHeader_Services_Price.Text = "Price";
            this.columnHeader_Services_Price.Width = 100;
            // 
            // listView_Foods
            // 
            this.listView_Foods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Foods,
            this.columnHeader_Foods_Price});
            this.listView_Foods.HideSelection = false;
            this.listView_Foods.Location = new System.Drawing.Point(200, 199);
            this.listView_Foods.Name = "listView_Foods";
            this.listView_Foods.Size = new System.Drawing.Size(174, 230);
            this.listView_Foods.TabIndex = 78;
            this.listView_Foods.UseCompatibleStateImageBehavior = false;
            this.listView_Foods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Foods
            // 
            this.columnHeader_Foods.Text = "Foods";
            this.columnHeader_Foods.Width = 71;
            // 
            // columnHeader_Foods_Price
            // 
            this.columnHeader_Foods_Price.Text = "Price";
            this.columnHeader_Foods_Price.Width = 100;
            // 
            // listView_Drinks
            // 
            this.listView_Drinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Drinks,
            this.columnHeader_Drinks_Price});
            this.listView_Drinks.HideSelection = false;
            this.listView_Drinks.Location = new System.Drawing.Point(19, 199);
            this.listView_Drinks.Name = "listView_Drinks";
            this.listView_Drinks.Size = new System.Drawing.Size(175, 230);
            this.listView_Drinks.TabIndex = 77;
            this.listView_Drinks.UseCompatibleStateImageBehavior = false;
            this.listView_Drinks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Drinks
            // 
            this.columnHeader_Drinks.Text = "Drinks";
            this.columnHeader_Drinks.Width = 71;
            // 
            // columnHeader_Drinks_Price
            // 
            this.columnHeader_Drinks_Price.Text = "Price";
            this.columnHeader_Drinks_Price.Width = 100;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(385, 477);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 54);
            this.button_Cancel.TabIndex = 76;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(466, 477);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(75, 54);
            this.button_Checkout.TabIndex = 75;
            this.button_Checkout.Text = "Checkout";
            this.button_Checkout.UseVisualStyleBackColor = true;
            this.button_Checkout.Click += new System.EventHandler(this.button_Checkout_Click);
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(364, 161);
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.ReadOnly = true;
            this.textBox_Note.Size = new System.Drawing.Size(179, 20);
            this.textBox_Note.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Note:";
            // 
            // textBox_GuestName
            // 
            this.textBox_GuestName.Location = new System.Drawing.Point(289, 60);
            this.textBox_GuestName.Name = "textBox_GuestName";
            this.textBox_GuestName.ReadOnly = true;
            this.textBox_GuestName.Size = new System.Drawing.Size(252, 20);
            this.textBox_GuestName.TabIndex = 60;
            // 
            // textBox_RoomID
            // 
            this.textBox_RoomID.Location = new System.Drawing.Point(91, 60);
            this.textBox_RoomID.Name = "textBox_RoomID";
            this.textBox_RoomID.ReadOnly = true;
            this.textBox_RoomID.Size = new System.Drawing.Size(100, 20);
            this.textBox_RoomID.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Checkout:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Checkin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Guest Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "RoomID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Room checkout:";
            // 
            // label_CheckoutDateTime
            // 
            this.label_CheckoutDateTime.AutoSize = true;
            this.label_CheckoutDateTime.Location = new System.Drawing.Point(363, 119);
            this.label_CheckoutDateTime.Name = "label_CheckoutDateTime";
            this.label_CheckoutDateTime.Size = new System.Drawing.Size(157, 13);
            this.label_CheckoutDateTime.TabIndex = 80;
            this.label_CheckoutDateTime.Text = "CheckoutDateTimePlaceHolder";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(88, 455);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(111, 13);
            this.label_TotalPrice.TabIndex = 81;
            this.label_TotalPrice.Text = "TotalPricePlaceholder";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(13, 455);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(34, 13);
            this.label_total.TabIndex = 52;
            this.label_total.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Total:";
            // 
            // label_TotalPriceOfTime
            // 
            this.label_TotalPriceOfTime.AutoSize = true;
            this.label_TotalPriceOfTime.Location = new System.Drawing.Point(88, 161);
            this.label_TotalPriceOfTime.Name = "label_TotalPriceOfTime";
            this.label_TotalPriceOfTime.Size = new System.Drawing.Size(145, 13);
            this.label_TotalPriceOfTime.TabIndex = 81;
            this.label_TotalPriceOfTime.Text = "TotalPriceOfTimePlaceholder";
            // 
            // RoomCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 540);
            this.Controls.Add(this.label_TotalPriceOfTime);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label_CheckoutDateTime);
            this.Controls.Add(this.label_CheckinDateTime);
            this.Controls.Add(this.listView_Services);
            this.Controls.Add(this.listView_Foods);
            this.Controls.Add(this.listView_Drinks);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Checkout);
            this.Controls.Add(this.textBox_Note);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_GuestName);
            this.Controls.Add(this.textBox_RoomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoomCheckout";
            this.Text = "RoomCheckout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CheckinDateTime;
        private System.Windows.Forms.ListView listView_Services;
        private System.Windows.Forms.ColumnHeader columnHeader_Services;
        private System.Windows.Forms.ColumnHeader columnHeader_Services_Price;
        private System.Windows.Forms.ListView listView_Foods;
        private System.Windows.Forms.ColumnHeader columnHeader_Foods;
        private System.Windows.Forms.ColumnHeader columnHeader_Foods_Price;
        private System.Windows.Forms.ListView listView_Drinks;
        private System.Windows.Forms.ColumnHeader columnHeader_Drinks;
        private System.Windows.Forms.ColumnHeader columnHeader_Drinks_Price;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_GuestName;
        private System.Windows.Forms.TextBox textBox_RoomID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CheckoutDateTime;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_TotalPriceOfTime;
    }
}