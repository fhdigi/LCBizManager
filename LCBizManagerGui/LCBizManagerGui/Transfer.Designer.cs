namespace LCBizManagerGui
{
    partial class Transfer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FromAccountLabel = new System.Windows.Forms.Label();
            this.ToAccount1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CheckDropDown = new System.Windows.Forms.ComboBox();
            this.SavingsDropDown = new System.Windows.Forms.ComboBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.AmountTextBox);
            this.groupBox1.Controls.Add(this.SavingsDropDown);
            this.groupBox1.Controls.Add(this.CheckDropDown);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.ToAccount1);
            this.groupBox1.Controls.Add(this.FromAccountLabel);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Funds";
            // 
            // FromAccountLabel
            // 
            this.FromAccountLabel.AutoSize = true;
            this.FromAccountLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromAccountLabel.Location = new System.Drawing.Point(6, 38);
            this.FromAccountLabel.Name = "FromAccountLabel";
            this.FromAccountLabel.Size = new System.Drawing.Size(84, 14);
            this.FromAccountLabel.TabIndex = 0;
            this.FromAccountLabel.Text = "From Account";
            // 
            // ToAccount1
            // 
            this.ToAccount1.AutoSize = true;
            this.ToAccount1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToAccount1.Location = new System.Drawing.Point(6, 73);
            this.ToAccount1.Name = "ToAccount1";
            this.ToAccount1.Size = new System.Drawing.Size(72, 14);
            this.ToAccount1.TabIndex = 1;
            this.ToAccount1.Text = "To Account";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(7, 106);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(51, 14);
            this.Amount.TabIndex = 2;
            this.Amount.Text = "Amount";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(10, 136);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(33, 14);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date";
            // 
            // CheckDropDown
            // 
            this.CheckDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CheckDropDown.FormattingEnabled = true;
            this.CheckDropDown.Location = new System.Drawing.Point(130, 35);
            this.CheckDropDown.Name = "CheckDropDown";
            this.CheckDropDown.Size = new System.Drawing.Size(320, 22);
            this.CheckDropDown.TabIndex = 4;
            this.CheckDropDown.Text = "First Heritage Checking";
            // 
            // SavingsDropDown
            // 
            this.SavingsDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SavingsDropDown.FormattingEnabled = true;
            this.SavingsDropDown.Location = new System.Drawing.Point(130, 70);
            this.SavingsDropDown.Name = "SavingsDropDown";
            this.SavingsDropDown.Size = new System.Drawing.Size(320, 22);
            this.SavingsDropDown.TabIndex = 5;
            this.SavingsDropDown.Text = "First Heritage Savings";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.AmountTextBox.Location = new System.Drawing.Point(130, 106);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(117, 22);
            this.AmountTextBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(479, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(479, 42);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 190);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Transfer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FromAccountLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label ToAccount1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.ComboBox CheckDropDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.ComboBox SavingsDropDown;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}