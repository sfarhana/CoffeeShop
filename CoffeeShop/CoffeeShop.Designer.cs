namespace CoffeeShop
{
    partial class CoffeeShop
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
            this.grpBoxCustInfo = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerName = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.grpBoxCustInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxCustInfo
            // 
            this.grpBoxCustInfo.Controls.Add(this.buttonShow);
            this.grpBoxCustInfo.Controls.Add(this.ContactNo);
            this.grpBoxCustInfo.Controls.Add(this.Address);
            this.grpBoxCustInfo.Controls.Add(this.Order);
            this.grpBoxCustInfo.Controls.Add(this.Quantity);
            this.grpBoxCustInfo.Controls.Add(this.CustomerName);
            this.grpBoxCustInfo.Controls.Add(this.orderComboBox);
            this.grpBoxCustInfo.Controls.Add(this.contactTextBox);
            this.grpBoxCustInfo.Controls.Add(this.addressTextBox);
            this.grpBoxCustInfo.Controls.Add(this.quantityTextBox);
            this.grpBoxCustInfo.Controls.Add(this.nameTextBox);
            this.grpBoxCustInfo.Location = new System.Drawing.Point(49, 37);
            this.grpBoxCustInfo.Name = "grpBoxCustInfo";
            this.grpBoxCustInfo.Size = new System.Drawing.Size(515, 391);
            this.grpBoxCustInfo.TabIndex = 0;
            this.grpBoxCustInfo.TabStop = false;
            this.grpBoxCustInfo.Text = "Customer Information";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(194, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 20);
            this.nameTextBox.TabIndex = 0;
            
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(194, 237);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(144, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(194, 133);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(144, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(194, 90);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(144, 20);
            this.contactTextBox.TabIndex = 3;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Reguler"});
            this.orderComboBox.Location = new System.Drawing.Point(194, 194);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(144, 21);
            this.orderComboBox.TabIndex = 4;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(84, 49);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(82, 13);
            this.CustomerName.TabIndex = 5;
            this.CustomerName.Text = "Customer Name";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(84, 237);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 6;
            this.Quantity.Text = "Quantity";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(84, 194);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(33, 13);
            this.Order.TabIndex = 7;
            this.Order.Text = "Order";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(84, 133);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Location = new System.Drawing.Point(84, 90);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(61, 13);
            this.ContactNo.TabIndex = 9;
            this.ContactNo.Text = "Contact No";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(194, 298);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Save";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(597, 49);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(319, 379);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 500);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.grpBoxCustInfo);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.grpBoxCustInfo.ResumeLayout(false);
            this.grpBoxCustInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCustInfo;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}