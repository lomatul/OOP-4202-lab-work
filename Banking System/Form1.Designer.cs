namespace Banking_System
{
    partial class Form1
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_add_account = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.groupBox_type = new System.Windows.Forms.GroupBox();
            this.radioButton_T_Current = new System.Windows.Forms.RadioButton();
            this.radioButton_T_loan = new System.Windows.Forms.RadioButton();
            this.radioButton_T_savings = new System.Windows.Forms.RadioButton();
            this.label_amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_show = new System.Windows.Forms.ListBox();
            this.button_showdetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_am = new System.Windows.Forms.Label();
            this.textBox_Balance = new System.Windows.Forms.TextBox();
            this.groupBox_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(36, 51);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name :";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(36, 187);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(64, 16);
            this.label_address.TabIndex = 2;
            this.label_address.Text = "Address :";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(36, 142);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(38, 16);
            this.label_mail.TabIndex = 3;
            this.label_mail.Text = "Mail :";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(32, 99);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(103, 16);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Phone Number :";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(141, 51);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(141, 181);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 22);
            this.textBox_address.TabIndex = 7;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(141, 136);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(100, 22);
            this.textBox_mail.TabIndex = 8;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(141, 93);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 22);
            this.textBox_phone.TabIndex = 9;
            // 
            // button_add_account
            // 
            this.button_add_account.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_add_account.Location = new System.Drawing.Point(228, 373);
            this.button_add_account.Name = "button_add_account";
            this.button_add_account.Size = new System.Drawing.Size(94, 47);
            this.button_add_account.TabIndex = 10;
            this.button_add_account.Text = "   Add\r\nAccount";
            this.button_add_account.UseVisualStyleBackColor = false;
            this.button_add_account.Click += new System.EventHandler(this.button_add_account_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(36, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 16);
            this.label.TabIndex = 11;
            this.label.Text = "CREATE AN ACCOUNT ";
            // 
            // groupBox_type
            // 
            this.groupBox_type.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_type.Controls.Add(this.radioButton_T_Current);
            this.groupBox_type.Controls.Add(this.radioButton_T_loan);
            this.groupBox_type.Controls.Add(this.radioButton_T_savings);
            this.groupBox_type.Location = new System.Drawing.Point(304, 45);
            this.groupBox_type.Name = "groupBox_type";
            this.groupBox_type.Size = new System.Drawing.Size(207, 158);
            this.groupBox_type.TabIndex = 13;
            this.groupBox_type.TabStop = false;
            this.groupBox_type.Text = "Type";
            // 
            // radioButton_T_Current
            // 
            this.radioButton_T_Current.AutoSize = true;
            this.radioButton_T_Current.Location = new System.Drawing.Point(27, 105);
            this.radioButton_T_Current.Name = "radioButton_T_Current";
            this.radioButton_T_Current.Size = new System.Drawing.Size(121, 20);
            this.radioButton_T_Current.TabIndex = 2;
            this.radioButton_T_Current.TabStop = true;
            this.radioButton_T_Current.Text = "Current Account";
            this.radioButton_T_Current.UseVisualStyleBackColor = true;
            // 
            // radioButton_T_loan
            // 
            this.radioButton_T_loan.AutoSize = true;
            this.radioButton_T_loan.Location = new System.Drawing.Point(26, 70);
            this.radioButton_T_loan.Name = "radioButton_T_loan";
            this.radioButton_T_loan.Size = new System.Drawing.Size(109, 20);
            this.radioButton_T_loan.TabIndex = 1;
            this.radioButton_T_loan.TabStop = true;
            this.radioButton_T_loan.Text = "Loan Account";
            this.radioButton_T_loan.UseVisualStyleBackColor = true;
            // 
            // radioButton_T_savings
            // 
            this.radioButton_T_savings.AutoSize = true;
            this.radioButton_T_savings.Location = new System.Drawing.Point(26, 35);
            this.radioButton_T_savings.Name = "radioButton_T_savings";
            this.radioButton_T_savings.Size = new System.Drawing.Size(128, 20);
            this.radioButton_T_savings.TabIndex = 0;
            this.radioButton_T_savings.TabStop = true;
            this.radioButton_T_savings.Text = "Savings Account";
            this.radioButton_T_savings.UseVisualStyleBackColor = true;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(672, 136);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(58, 16);
            this.label_amount.TabIndex = 14;
            this.label_amount.Text = "Amount :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(664, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(794, 136);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 22);
            this.textBox_amount.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Location = new System.Drawing.Point(841, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_show
            // 
            this.listBox_show.BackColor = System.Drawing.Color.Thistle;
            this.listBox_show.FormattingEnabled = true;
            this.listBox_show.ItemHeight = 16;
            this.listBox_show.Location = new System.Drawing.Point(664, 297);
            this.listBox_show.Name = "listBox_show";
            this.listBox_show.Size = new System.Drawing.Size(469, 132);
            this.listBox_show.TabIndex = 20;
            // 
            // button_showdetails
            // 
            this.button_showdetails.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_showdetails.Location = new System.Drawing.Point(1030, 220);
            this.button_showdetails.Name = "button_showdetails";
            this.button_showdetails.Size = new System.Drawing.Size(90, 26);
            this.button_showdetails.TabIndex = 23;
            this.button_showdetails.Text = "Show details";
            this.button_showdetails.UseVisualStyleBackColor = false;
            this.button_showdetails.Click += new System.EventHandler(this.button_showdetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter ID :";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(794, 51);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(794, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(581, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 447);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label_am
            // 
            this.label_am.AutoSize = true;
            this.label_am.Location = new System.Drawing.Point(36, 265);
            this.label_am.Name = "label_am";
            this.label_am.Size = new System.Drawing.Size(63, 16);
            this.label_am.TabIndex = 31;
            this.label_am.Text = "Balance :";
            // 
            // textBox_Balance
            // 
            this.textBox_Balance.Location = new System.Drawing.Point(141, 259);
            this.textBox_Balance.Name = "textBox_Balance";
            this.textBox_Balance.Size = new System.Drawing.Size(100, 22);
            this.textBox_Balance.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1250, 477);
            this.Controls.Add(this.textBox_Balance);
            this.Controls.Add(this.label_am);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_showdetails);
            this.Controls.Add(this.listBox_show);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.groupBox_type);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_add_account);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_type.ResumeLayout(false);
            this.groupBox_type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_add_account;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox_type;
        private System.Windows.Forms.RadioButton radioButton_T_savings;
        private System.Windows.Forms.RadioButton radioButton_T_Current;
        private System.Windows.Forms.RadioButton radioButton_T_loan;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_show;
        private System.Windows.Forms.Button button_showdetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_am;
        private System.Windows.Forms.TextBox textBox_Balance;
    }
}

