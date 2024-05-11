namespace Re_QuanLiKS
{
    partial class AddNewRoom
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_CheckinDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CheckoutDate = new System.Windows.Forms.DateTimePicker();
            this.checkBox_CheckoutUnknownDate = new System.Windows.Forms.CheckBox();
            this.textBox_RoomID = new System.Windows.Forms.TextBox();
            this.textBox_GuestName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Drinks = new System.Windows.Forms.ComboBox();
            this.button_PlusDrinks = new System.Windows.Forms.Button();
            this.button_MinusDrinks = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Foods = new System.Windows.Forms.ComboBox();
            this.button_PlusFoods = new System.Windows.Forms.Button();
            this.button_MinusFoods = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Services = new System.Windows.Forms.ComboBox();
            this.button_PlusServices = new System.Windows.Forms.Button();
            this.button_MinusServices = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.dateTimePicker_CheckoutTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CheckinTime = new System.Windows.Forms.DateTimePicker();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.listView_Drinks = new System.Windows.Forms.ListView();
            this.columnHeader_Drinks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Drinks_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Foods = new System.Windows.Forms.ListView();
            this.columnHeader_Foods = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Foods_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Services = new System.Windows.Forms.ListView();
            this.columnHeader_Services = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Services_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RoomID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Checkin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Checkout:";
            // 
            // dateTimePicker_CheckinDate
            // 
            this.dateTimePicker_CheckinDate.Location = new System.Drawing.Point(92, 113);
            this.dateTimePicker_CheckinDate.Name = "dateTimePicker_CheckinDate";
            this.dateTimePicker_CheckinDate.Size = new System.Drawing.Size(191, 22);
            this.dateTimePicker_CheckinDate.TabIndex = 4;
            // 
            // dateTimePicker_CheckoutDate
            // 
            this.dateTimePicker_CheckoutDate.Location = new System.Drawing.Point(92, 165);
            this.dateTimePicker_CheckoutDate.Name = "dateTimePicker_CheckoutDate";
            this.dateTimePicker_CheckoutDate.Size = new System.Drawing.Size(191, 22);
            this.dateTimePicker_CheckoutDate.TabIndex = 4;
            // 
            // checkBox_CheckoutUnknownDate
            // 
            this.checkBox_CheckoutUnknownDate.AutoSize = true;
            this.checkBox_CheckoutUnknownDate.Location = new System.Drawing.Point(429, 164);
            this.checkBox_CheckoutUnknownDate.Name = "checkBox_CheckoutUnknownDate";
            this.checkBox_CheckoutUnknownDate.Size = new System.Drawing.Size(113, 20);
            this.checkBox_CheckoutUnknownDate.TabIndex = 5;
            this.checkBox_CheckoutUnknownDate.Text = "Unknown Date";
            this.checkBox_CheckoutUnknownDate.UseVisualStyleBackColor = true;
            // 
            // textBox_RoomID
            // 
            this.textBox_RoomID.Location = new System.Drawing.Point(92, 59);
            this.textBox_RoomID.Name = "textBox_RoomID";
            this.textBox_RoomID.Size = new System.Drawing.Size(100, 22);
            this.textBox_RoomID.TabIndex = 6;
            // 
            // textBox_GuestName
            // 
            this.textBox_GuestName.Location = new System.Drawing.Point(290, 59);
            this.textBox_GuestName.Name = "textBox_GuestName";
            this.textBox_GuestName.Size = new System.Drawing.Size(252, 22);
            this.textBox_GuestName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Drinks:";
            // 
            // comboBox_Drinks
            // 
            this.comboBox_Drinks.FormattingEnabled = true;
            this.comboBox_Drinks.Location = new System.Drawing.Point(92, 213);
            this.comboBox_Drinks.Name = "comboBox_Drinks";
            this.comboBox_Drinks.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Drinks.TabIndex = 9;
            // 
            // button_PlusDrinks
            // 
            this.button_PlusDrinks.Location = new System.Drawing.Point(219, 214);
            this.button_PlusDrinks.Name = "button_PlusDrinks";
            this.button_PlusDrinks.Size = new System.Drawing.Size(23, 23);
            this.button_PlusDrinks.TabIndex = 10;
            this.button_PlusDrinks.Text = "+";
            this.button_PlusDrinks.UseVisualStyleBackColor = true;
            this.button_PlusDrinks.Click += new System.EventHandler(this.button_PlusDrinks_Click);
            // 
            // button_MinusDrinks
            // 
            this.button_MinusDrinks.Location = new System.Drawing.Point(248, 214);
            this.button_MinusDrinks.Name = "button_MinusDrinks";
            this.button_MinusDrinks.Size = new System.Drawing.Size(23, 23);
            this.button_MinusDrinks.TabIndex = 10;
            this.button_MinusDrinks.Text = "-";
            this.button_MinusDrinks.UseVisualStyleBackColor = true;
            this.button_MinusDrinks.Click += new System.EventHandler(this.button_MinusDrinks_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Foods:";
            // 
            // comboBox_Foods
            // 
            this.comboBox_Foods.FormattingEnabled = true;
            this.comboBox_Foods.Location = new System.Drawing.Point(363, 214);
            this.comboBox_Foods.Name = "comboBox_Foods";
            this.comboBox_Foods.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Foods.TabIndex = 9;
            // 
            // button_PlusFoods
            // 
            this.button_PlusFoods.Location = new System.Drawing.Point(490, 214);
            this.button_PlusFoods.Name = "button_PlusFoods";
            this.button_PlusFoods.Size = new System.Drawing.Size(23, 23);
            this.button_PlusFoods.TabIndex = 10;
            this.button_PlusFoods.Text = "+";
            this.button_PlusFoods.UseVisualStyleBackColor = true;
            this.button_PlusFoods.Click += new System.EventHandler(this.button_PlusFoods_Click);
            // 
            // button_MinusFoods
            // 
            this.button_MinusFoods.Location = new System.Drawing.Point(519, 214);
            this.button_MinusFoods.Name = "button_MinusFoods";
            this.button_MinusFoods.Size = new System.Drawing.Size(23, 23);
            this.button_MinusFoods.TabIndex = 10;
            this.button_MinusFoods.Text = "-";
            this.button_MinusFoods.UseVisualStyleBackColor = true;
            this.button_MinusFoods.Click += new System.EventHandler(this.button_MinusFoods_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Services:";
            // 
            // comboBox_Services
            // 
            this.comboBox_Services.FormattingEnabled = true;
            this.comboBox_Services.Location = new System.Drawing.Point(92, 265);
            this.comboBox_Services.Name = "comboBox_Services";
            this.comboBox_Services.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Services.TabIndex = 9;
            // 
            // button_PlusServices
            // 
            this.button_PlusServices.Location = new System.Drawing.Point(219, 266);
            this.button_PlusServices.Name = "button_PlusServices";
            this.button_PlusServices.Size = new System.Drawing.Size(23, 23);
            this.button_PlusServices.TabIndex = 10;
            this.button_PlusServices.Text = "+";
            this.button_PlusServices.UseVisualStyleBackColor = true;
            this.button_PlusServices.Click += new System.EventHandler(this.button_PlusServices_Click);
            // 
            // button_MinusServices
            // 
            this.button_MinusServices.Location = new System.Drawing.Point(248, 266);
            this.button_MinusServices.Name = "button_MinusServices";
            this.button_MinusServices.Size = new System.Drawing.Size(23, 23);
            this.button_MinusServices.TabIndex = 10;
            this.button_MinusServices.Text = "-";
            this.button_MinusServices.UseVisualStyleBackColor = true;
            this.button_MinusServices.Click += new System.EventHandler(this.button_MinusServices_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Note:";
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(363, 267);
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(179, 22);
            this.textBox_Note.TabIndex = 12;
            // 
            // dateTimePicker_CheckoutTime
            // 
            this.dateTimePicker_CheckoutTime.CustomFormat = "HH:mm";
            this.dateTimePicker_CheckoutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CheckoutTime.Location = new System.Drawing.Point(290, 164);
            this.dateTimePicker_CheckoutTime.Name = "dateTimePicker_CheckoutTime";
            this.dateTimePicker_CheckoutTime.ShowUpDown = true;
            this.dateTimePicker_CheckoutTime.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker_CheckoutTime.TabIndex = 4;
            // 
            // dateTimePicker_CheckinTime
            // 
            this.dateTimePicker_CheckinTime.CustomFormat = "HH:mm";
            this.dateTimePicker_CheckinTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CheckinTime.Location = new System.Drawing.Point(290, 112);
            this.dateTimePicker_CheckinTime.Name = "dateTimePicker_CheckinTime";
            this.dateTimePicker_CheckinTime.ShowUpDown = true;
            this.dateTimePicker_CheckinTime.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker_CheckinTime.TabIndex = 4;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(905, 295);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 54);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(824, 295);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 54);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // listView_Drinks
            // 
            this.listView_Drinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Drinks,
            this.columnHeader_Drinks_Amount});
            this.listView_Drinks.HideSelection = false;
            this.listView_Drinks.Location = new System.Drawing.Point(548, 59);
            this.listView_Drinks.Name = "listView_Drinks";
            this.listView_Drinks.Size = new System.Drawing.Size(140, 230);
            this.listView_Drinks.TabIndex = 16;
            this.listView_Drinks.UseCompatibleStateImageBehavior = false;
            this.listView_Drinks.View = System.Windows.Forms.View.Details;
            this.listView_Drinks.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_Drinks_ColumnWidthChanging);
            // 
            // columnHeader_Drinks
            // 
            this.columnHeader_Drinks.Text = "Drinks";
            this.columnHeader_Drinks.Width = 71;
            // 
            // columnHeader_Drinks_Amount
            // 
            this.columnHeader_Drinks_Amount.Text = "Amount";
            this.columnHeader_Drinks_Amount.Width = 65;
            // 
            // listView_Foods
            // 
            this.listView_Foods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Foods,
            this.columnHeader_Foods_Amount});
            this.listView_Foods.HideSelection = false;
            this.listView_Foods.Location = new System.Drawing.Point(694, 59);
            this.listView_Foods.Name = "listView_Foods";
            this.listView_Foods.Size = new System.Drawing.Size(140, 230);
            this.listView_Foods.TabIndex = 16;
            this.listView_Foods.UseCompatibleStateImageBehavior = false;
            this.listView_Foods.View = System.Windows.Forms.View.Details;
            this.listView_Foods.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_Drinks_ColumnWidthChanging);
            // 
            // columnHeader_Foods
            // 
            this.columnHeader_Foods.Text = "Foods";
            this.columnHeader_Foods.Width = 71;
            // 
            // columnHeader_Foods_Amount
            // 
            this.columnHeader_Foods_Amount.Text = "Amount";
            this.columnHeader_Foods_Amount.Width = 65;
            // 
            // listView_Services
            // 
            this.listView_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Services,
            this.columnHeader_Services_Amount});
            this.listView_Services.HideSelection = false;
            this.listView_Services.Location = new System.Drawing.Point(837, 59);
            this.listView_Services.Name = "listView_Services";
            this.listView_Services.Size = new System.Drawing.Size(140, 230);
            this.listView_Services.TabIndex = 16;
            this.listView_Services.UseCompatibleStateImageBehavior = false;
            this.listView_Services.View = System.Windows.Forms.View.Details;
            this.listView_Services.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_Drinks_ColumnWidthChanging);
            // 
            // columnHeader_Services
            // 
            this.columnHeader_Services.Text = "Services";
            this.columnHeader_Services.Width = 71;
            // 
            // columnHeader_Services_Amount
            // 
            this.columnHeader_Services_Amount.Text = "Amount";
            this.columnHeader_Services_Amount.Width = 65;
            // 
            // AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 361);
            this.Controls.Add(this.listView_Services);
            this.Controls.Add(this.listView_Foods);
            this.Controls.Add(this.listView_Drinks);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Note);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_MinusFoods);
            this.Controls.Add(this.button_MinusServices);
            this.Controls.Add(this.button_MinusDrinks);
            this.Controls.Add(this.button_PlusFoods);
            this.Controls.Add(this.button_PlusServices);
            this.Controls.Add(this.button_PlusDrinks);
            this.Controls.Add(this.comboBox_Foods);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Services);
            this.Controls.Add(this.comboBox_Drinks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_GuestName);
            this.Controls.Add(this.textBox_RoomID);
            this.Controls.Add(this.checkBox_CheckoutUnknownDate);
            this.Controls.Add(this.dateTimePicker_CheckoutDate);
            this.Controls.Add(this.dateTimePicker_CheckinTime);
            this.Controls.Add(this.dateTimePicker_CheckoutTime);
            this.Controls.Add(this.dateTimePicker_CheckinDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewRoom";
            this.Text = "AddNewRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckinDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckoutDate;
        private System.Windows.Forms.CheckBox checkBox_CheckoutUnknownDate;
        private System.Windows.Forms.TextBox textBox_RoomID;
        private System.Windows.Forms.TextBox textBox_GuestName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Drinks;
        private System.Windows.Forms.Button button_PlusDrinks;
        private System.Windows.Forms.Button button_MinusDrinks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Foods;
        private System.Windows.Forms.Button button_PlusFoods;
        private System.Windows.Forms.Button button_MinusFoods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Services;
        private System.Windows.Forms.Button button_PlusServices;
        private System.Windows.Forms.Button button_MinusServices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckoutTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckinTime;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ListView listView_Drinks;
        private System.Windows.Forms.ColumnHeader columnHeader_Drinks;
        private System.Windows.Forms.ColumnHeader columnHeader_Drinks_Amount;
        private System.Windows.Forms.ListView listView_Foods;
        private System.Windows.Forms.ColumnHeader columnHeader_Foods;
        private System.Windows.Forms.ColumnHeader columnHeader_Foods_Amount;
        private System.Windows.Forms.ListView listView_Services;
        private System.Windows.Forms.ColumnHeader columnHeader_Services;
        private System.Windows.Forms.ColumnHeader columnHeader_Services_Amount;
    }
}