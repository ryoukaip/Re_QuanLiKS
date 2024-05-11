namespace Re_QuanLiKS
{
    partial class EditRoom
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
            this.columnHeader_Services_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Services = new System.Windows.Forms.ListView();
            this.columnHeader_Services = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Foods_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Foods = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Foods = new System.Windows.Forms.ListView();
            this.columnHeader_Drinks_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Drinks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Drinks = new System.Windows.Forms.ListView();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_MinusFoods = new System.Windows.Forms.Button();
            this.button_MinusServices = new System.Windows.Forms.Button();
            this.button_MinusDrinks = new System.Windows.Forms.Button();
            this.button_PlusFoods = new System.Windows.Forms.Button();
            this.button_PlusServices = new System.Windows.Forms.Button();
            this.button_PlusDrinks = new System.Windows.Forms.Button();
            this.comboBox_Foods = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Services = new System.Windows.Forms.ComboBox();
            this.comboBox_Drinks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_GuestName = new System.Windows.Forms.TextBox();
            this.textBox_RoomID = new System.Windows.Forms.TextBox();
            this.checkBox_CheckoutUnknownDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_CheckoutDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CheckoutTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CheckinDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader_Services_Amount
            // 
            this.columnHeader_Services_Amount.Text = "Amount";
            this.columnHeader_Services_Amount.Width = 65;
            // 
            // listView_Services
            // 
            this.listView_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Services,
            this.columnHeader_Services_Amount});
            this.listView_Services.HideSelection = false;
            this.listView_Services.Location = new System.Drawing.Point(836, 60);
            this.listView_Services.Name = "listView_Services";
            this.listView_Services.Size = new System.Drawing.Size(140, 230);
            this.listView_Services.TabIndex = 47;
            this.listView_Services.UseCompatibleStateImageBehavior = false;
            this.listView_Services.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Services
            // 
            this.columnHeader_Services.Text = "Services";
            this.columnHeader_Services.Width = 71;
            // 
            // columnHeader_Foods_Amount
            // 
            this.columnHeader_Foods_Amount.Text = "Amount";
            this.columnHeader_Foods_Amount.Width = 65;
            // 
            // columnHeader_Foods
            // 
            this.columnHeader_Foods.Text = "Foods";
            this.columnHeader_Foods.Width = 71;
            // 
            // listView_Foods
            // 
            this.listView_Foods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Foods,
            this.columnHeader_Foods_Amount});
            this.listView_Foods.HideSelection = false;
            this.listView_Foods.Location = new System.Drawing.Point(693, 60);
            this.listView_Foods.Name = "listView_Foods";
            this.listView_Foods.Size = new System.Drawing.Size(140, 230);
            this.listView_Foods.TabIndex = 46;
            this.listView_Foods.UseCompatibleStateImageBehavior = false;
            this.listView_Foods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Drinks_Amount
            // 
            this.columnHeader_Drinks_Amount.Text = "Amount";
            this.columnHeader_Drinks_Amount.Width = 65;
            // 
            // columnHeader_Drinks
            // 
            this.columnHeader_Drinks.Text = "Drinks";
            this.columnHeader_Drinks.Width = 71;
            // 
            // listView_Drinks
            // 
            this.listView_Drinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Drinks,
            this.columnHeader_Drinks_Amount});
            this.listView_Drinks.HideSelection = false;
            this.listView_Drinks.Location = new System.Drawing.Point(547, 60);
            this.listView_Drinks.Name = "listView_Drinks";
            this.listView_Drinks.Size = new System.Drawing.Size(140, 230);
            this.listView_Drinks.TabIndex = 45;
            this.listView_Drinks.UseCompatibleStateImageBehavior = false;
            this.listView_Drinks.View = System.Windows.Forms.View.Details;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(823, 296);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 54);
            this.button_Cancel.TabIndex = 44;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(904, 296);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 54);
            this.button_Update.TabIndex = 43;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(362, 268);
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(179, 20);
            this.textBox_Note.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Services:";
            // 
            // button_MinusFoods
            // 
            this.button_MinusFoods.Location = new System.Drawing.Point(518, 215);
            this.button_MinusFoods.Name = "button_MinusFoods";
            this.button_MinusFoods.Size = new System.Drawing.Size(23, 23);
            this.button_MinusFoods.TabIndex = 40;
            this.button_MinusFoods.Text = "-";
            this.button_MinusFoods.UseVisualStyleBackColor = true;
            this.button_MinusFoods.Click += new System.EventHandler(this.button_MinusFoods_Click);
            // 
            // button_MinusServices
            // 
            this.button_MinusServices.Location = new System.Drawing.Point(247, 267);
            this.button_MinusServices.Name = "button_MinusServices";
            this.button_MinusServices.Size = new System.Drawing.Size(23, 23);
            this.button_MinusServices.TabIndex = 39;
            this.button_MinusServices.Text = "-";
            this.button_MinusServices.UseVisualStyleBackColor = true;
            this.button_MinusServices.Click += new System.EventHandler(this.button_MinusServices_Click);
            // 
            // button_MinusDrinks
            // 
            this.button_MinusDrinks.Location = new System.Drawing.Point(247, 215);
            this.button_MinusDrinks.Name = "button_MinusDrinks";
            this.button_MinusDrinks.Size = new System.Drawing.Size(23, 23);
            this.button_MinusDrinks.TabIndex = 38;
            this.button_MinusDrinks.Text = "-";
            this.button_MinusDrinks.UseVisualStyleBackColor = true;
            this.button_MinusDrinks.Click += new System.EventHandler(this.button_MinusDrinks_Click);
            // 
            // button_PlusFoods
            // 
            this.button_PlusFoods.Location = new System.Drawing.Point(489, 215);
            this.button_PlusFoods.Name = "button_PlusFoods";
            this.button_PlusFoods.Size = new System.Drawing.Size(23, 23);
            this.button_PlusFoods.TabIndex = 37;
            this.button_PlusFoods.Text = "+";
            this.button_PlusFoods.UseVisualStyleBackColor = true;
            this.button_PlusFoods.Click += new System.EventHandler(this.button_PlusFoods_Click);
            // 
            // button_PlusServices
            // 
            this.button_PlusServices.Location = new System.Drawing.Point(218, 267);
            this.button_PlusServices.Name = "button_PlusServices";
            this.button_PlusServices.Size = new System.Drawing.Size(23, 23);
            this.button_PlusServices.TabIndex = 36;
            this.button_PlusServices.Text = "+";
            this.button_PlusServices.UseVisualStyleBackColor = true;
            this.button_PlusServices.Click += new System.EventHandler(this.button_PlusServices_Click);
            // 
            // button_PlusDrinks
            // 
            this.button_PlusDrinks.Location = new System.Drawing.Point(218, 215);
            this.button_PlusDrinks.Name = "button_PlusDrinks";
            this.button_PlusDrinks.Size = new System.Drawing.Size(23, 23);
            this.button_PlusDrinks.TabIndex = 35;
            this.button_PlusDrinks.Text = "+";
            this.button_PlusDrinks.UseVisualStyleBackColor = true;
            this.button_PlusDrinks.Click += new System.EventHandler(this.button_PlusDrinks_Click);
            // 
            // comboBox_Foods
            // 
            this.comboBox_Foods.FormattingEnabled = true;
            this.comboBox_Foods.Location = new System.Drawing.Point(362, 215);
            this.comboBox_Foods.Name = "comboBox_Foods";
            this.comboBox_Foods.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Foods.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Foods:";
            // 
            // comboBox_Services
            // 
            this.comboBox_Services.FormattingEnabled = true;
            this.comboBox_Services.Location = new System.Drawing.Point(91, 266);
            this.comboBox_Services.Name = "comboBox_Services";
            this.comboBox_Services.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Services.TabIndex = 32;
            // 
            // comboBox_Drinks
            // 
            this.comboBox_Drinks.FormattingEnabled = true;
            this.comboBox_Drinks.Location = new System.Drawing.Point(91, 214);
            this.comboBox_Drinks.Name = "comboBox_Drinks";
            this.comboBox_Drinks.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Drinks.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Drinks:";
            // 
            // textBox_GuestName
            // 
            this.textBox_GuestName.Location = new System.Drawing.Point(289, 60);
            this.textBox_GuestName.Name = "textBox_GuestName";
            this.textBox_GuestName.Size = new System.Drawing.Size(252, 20);
            this.textBox_GuestName.TabIndex = 28;
            // 
            // textBox_RoomID
            // 
            this.textBox_RoomID.Location = new System.Drawing.Point(91, 60);
            this.textBox_RoomID.Name = "textBox_RoomID";
            this.textBox_RoomID.ReadOnly = true;
            this.textBox_RoomID.Size = new System.Drawing.Size(100, 20);
            this.textBox_RoomID.TabIndex = 27;
            // 
            // checkBox_CheckoutUnknownDate
            // 
            this.checkBox_CheckoutUnknownDate.AutoSize = true;
            this.checkBox_CheckoutUnknownDate.Location = new System.Drawing.Point(428, 165);
            this.checkBox_CheckoutUnknownDate.Name = "checkBox_CheckoutUnknownDate";
            this.checkBox_CheckoutUnknownDate.Size = new System.Drawing.Size(98, 17);
            this.checkBox_CheckoutUnknownDate.TabIndex = 26;
            this.checkBox_CheckoutUnknownDate.Text = "Unknown Date";
            this.checkBox_CheckoutUnknownDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_CheckoutDate
            // 
            this.dateTimePicker_CheckoutDate.Location = new System.Drawing.Point(91, 166);
            this.dateTimePicker_CheckoutDate.Name = "dateTimePicker_CheckoutDate";
            this.dateTimePicker_CheckoutDate.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker_CheckoutDate.TabIndex = 25;
            // 
            // dateTimePicker_CheckoutTime
            // 
            this.dateTimePicker_CheckoutTime.CustomFormat = "HH:mm";
            this.dateTimePicker_CheckoutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CheckoutTime.Location = new System.Drawing.Point(289, 165);
            this.dateTimePicker_CheckoutTime.Name = "dateTimePicker_CheckoutTime";
            this.dateTimePicker_CheckoutTime.ShowUpDown = true;
            this.dateTimePicker_CheckoutTime.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker_CheckoutTime.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Checkout:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Checkin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Guest Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "RoomID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Room:";
            // 
            // label_CheckinDateTime
            // 
            this.label_CheckinDateTime.AutoSize = true;
            this.label_CheckinDateTime.Location = new System.Drawing.Point(91, 118);
            this.label_CheckinDateTime.Name = "label_CheckinDateTime";
            this.label_CheckinDateTime.Size = new System.Drawing.Size(150, 13);
            this.label_CheckinDateTime.TabIndex = 48;
            this.label_CheckinDateTime.Text = "CheckinDateTimePlaceHolder";
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 361);
            this.Controls.Add(this.label_CheckinDateTime);
            this.Controls.Add(this.listView_Services);
            this.Controls.Add(this.listView_Foods);
            this.Controls.Add(this.listView_Drinks);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Update);
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
            this.Controls.Add(this.dateTimePicker_CheckoutTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader_Services_Amount;
        private System.Windows.Forms.ListView listView_Services;
        private System.Windows.Forms.ColumnHeader columnHeader_Services;
        private System.Windows.Forms.ColumnHeader columnHeader_Foods_Amount;
        private System.Windows.Forms.ColumnHeader columnHeader_Foods;
        private System.Windows.Forms.ListView listView_Foods;
        private System.Windows.Forms.ColumnHeader columnHeader_Drinks_Amount;
        private System.Windows.Forms.ColumnHeader columnHeader_Drinks;
        private System.Windows.Forms.ListView listView_Drinks;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_MinusFoods;
        private System.Windows.Forms.Button button_MinusServices;
        private System.Windows.Forms.Button button_MinusDrinks;
        private System.Windows.Forms.Button button_PlusFoods;
        private System.Windows.Forms.Button button_PlusServices;
        private System.Windows.Forms.Button button_PlusDrinks;
        private System.Windows.Forms.ComboBox comboBox_Foods;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Services;
        private System.Windows.Forms.ComboBox comboBox_Drinks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_GuestName;
        private System.Windows.Forms.TextBox textBox_RoomID;
        private System.Windows.Forms.CheckBox checkBox_CheckoutUnknownDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckoutDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckoutTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CheckinDateTime;
    }
}