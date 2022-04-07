namespace pharmacy_management
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
            this.textBox_mediname = new System.Windows.Forms.TextBox();
            this.textBox_sellqty = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_sellname = new System.Windows.Forms.TextBox();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.button_addmedi = new System.Windows.Forms.Button();
            this.listBox_medi = new System.Windows.Forms.ListBox();
            this.button_showmedi = new System.Windows.Forms.Button();
            this.button_sellmedi = new System.Windows.Forms.Button();
            this.listBox_balance = new System.Windows.Forms.ListBox();
            this.button_amount = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_mediname
            // 
            this.textBox_mediname.Location = new System.Drawing.Point(103, 56);
            this.textBox_mediname.Name = "textBox_mediname";
            this.textBox_mediname.Size = new System.Drawing.Size(100, 22);
            this.textBox_mediname.TabIndex = 0;
            this.textBox_mediname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_sellqty
            // 
            this.textBox_sellqty.Location = new System.Drawing.Point(759, 96);
            this.textBox_sellqty.Name = "textBox_sellqty";
            this.textBox_sellqty.Size = new System.Drawing.Size(100, 22);
            this.textBox_sellqty.TabIndex = 2;
            this.textBox_sellqty.Text = " ";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(103, 128);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 22);
            this.textBox_price.TabIndex = 3;
            // 
            // textBox_sellname
            // 
            this.textBox_sellname.Location = new System.Drawing.Point(759, 56);
            this.textBox_sellname.Name = "textBox_sellname";
            this.textBox_sellname.Size = new System.Drawing.Size(100, 22);
            this.textBox_sellname.TabIndex = 4;
            // 
            // textBox_qty
            // 
            this.textBox_qty.Location = new System.Drawing.Point(103, 93);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(100, 22);
            this.textBox_qty.TabIndex = 5;
            // 
            // button_addmedi
            // 
            this.button_addmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addmedi.Location = new System.Drawing.Point(32, 191);
            this.button_addmedi.Name = "button_addmedi";
            this.button_addmedi.Size = new System.Drawing.Size(75, 49);
            this.button_addmedi.TabIndex = 6;
            this.button_addmedi.Text = "Add Medi ";
            this.button_addmedi.UseVisualStyleBackColor = true;
            this.button_addmedi.Click += new System.EventHandler(this.button_addmedi_Click);
            // 
            // listBox_medi
            // 
            this.listBox_medi.BackColor = System.Drawing.Color.SandyBrown;
            this.listBox_medi.FormattingEnabled = true;
            this.listBox_medi.ItemHeight = 16;
            this.listBox_medi.Location = new System.Drawing.Point(32, 264);
            this.listBox_medi.Name = "listBox_medi";
            this.listBox_medi.Size = new System.Drawing.Size(493, 244);
            this.listBox_medi.TabIndex = 7;
            this.listBox_medi.SelectedIndexChanged += new System.EventHandler(this.listBox_medi_SelectedIndexChanged);
            // 
            // button_showmedi
            // 
            this.button_showmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showmedi.Location = new System.Drawing.Point(32, 524);
            this.button_showmedi.Name = "button_showmedi";
            this.button_showmedi.Size = new System.Drawing.Size(75, 57);
            this.button_showmedi.TabIndex = 8;
            this.button_showmedi.Text = "show Medi ";
            this.button_showmedi.UseVisualStyleBackColor = true;
            this.button_showmedi.Click += new System.EventHandler(this.button_showmedi_Click);
            // 
            // button_sellmedi
            // 
            this.button_sellmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sellmedi.Location = new System.Drawing.Point(696, 163);
            this.button_sellmedi.Name = "button_sellmedi";
            this.button_sellmedi.Size = new System.Drawing.Size(75, 49);
            this.button_sellmedi.TabIndex = 9;
            this.button_sellmedi.Text = "Sell\r\n Medi ";
            this.button_sellmedi.UseVisualStyleBackColor = true;
            this.button_sellmedi.Click += new System.EventHandler(this.button_sellmedi_Click);
            // 
            // listBox_balance
            // 
            this.listBox_balance.BackColor = System.Drawing.Color.SandyBrown;
            this.listBox_balance.FormattingEnabled = true;
            this.listBox_balance.ItemHeight = 16;
            this.listBox_balance.Location = new System.Drawing.Point(696, 246);
            this.listBox_balance.Name = "listBox_balance";
            this.listBox_balance.Size = new System.Drawing.Size(488, 244);
            this.listBox_balance.TabIndex = 10;
            this.listBox_balance.SelectedIndexChanged += new System.EventHandler(this.listBox_balance_SelectedIndexChanged);
            // 
            // button_amount
            // 
            this.button_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_amount.Location = new System.Drawing.Point(696, 524);
            this.button_amount.Name = "button_amount";
            this.button_amount.Size = new System.Drawing.Size(75, 57);
            this.button_amount.TabIndex = 11;
            this.button_amount.Text = "Show amount";
            this.button_amount.UseVisualStyleBackColor = true;
            this.button_amount.Click += new System.EventHandler(this.button_showstock_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(103, 163);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 22);
            this.textBox_amount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "QTY  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(693, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Qty: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(693, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Medicine sell : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Medicine Info : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1397, 656);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button_amount);
            this.Controls.Add(this.listBox_balance);
            this.Controls.Add(this.button_sellmedi);
            this.Controls.Add(this.button_showmedi);
            this.Controls.Add(this.listBox_medi);
            this.Controls.Add(this.button_addmedi);
            this.Controls.Add(this.textBox_qty);
            this.Controls.Add(this.textBox_sellname);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_sellqty);
            this.Controls.Add(this.textBox_mediname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mediname;
        private System.Windows.Forms.TextBox textBox_sellqty;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_sellname;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Button button_addmedi;
        private System.Windows.Forms.ListBox listBox_medi;
        private System.Windows.Forms.Button button_showmedi;
        private System.Windows.Forms.Button button_sellmedi;
        private System.Windows.Forms.ListBox listBox_balance;
        private System.Windows.Forms.Button button_amount;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

