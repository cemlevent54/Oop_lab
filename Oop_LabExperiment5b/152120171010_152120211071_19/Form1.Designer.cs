namespace _152120171010_152120211071_19
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.listBoxDistrict = new System.Windows.Forms.ListBox();
            this.listBoxSiparisler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SiparisLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(195, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(195, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 24);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon Numarası:";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 18;
            this.listBoxMenu.Items.AddRange(new object[] {
            "Hamburger",
            "Döner",
            "Pizza"});
            this.listBoxMenu.Location = new System.Drawing.Point(96, 198);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(247, 130);
            this.listBoxMenu.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(96, 362);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparis.Location = new System.Drawing.Point(57, 576);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(95, 31);
            this.btnSiparis.TabIndex = 8;
            this.btnSiparis.Text = "Sipariş Ver";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // listBoxCity
            // 
            this.listBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 18;
            this.listBoxCity.Items.AddRange(new object[] {
            "Eskişehir",
            "Bursa"});
            this.listBoxCity.Location = new System.Drawing.Point(417, 89);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(230, 130);
            this.listBoxCity.TabIndex = 9;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // listBoxDistrict
            // 
            this.listBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDistrict.FormattingEnabled = true;
            this.listBoxDistrict.ItemHeight = 18;
            this.listBoxDistrict.Location = new System.Drawing.Point(417, 297);
            this.listBoxDistrict.Name = "listBoxDistrict";
            this.listBoxDistrict.Size = new System.Drawing.Size(230, 130);
            this.listBoxDistrict.TabIndex = 10;
            // 
            // listBoxSiparisler
            // 
            this.listBoxSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSiparisler.FormattingEnabled = true;
            this.listBoxSiparisler.ItemHeight = 18;
            this.listBoxSiparisler.Location = new System.Drawing.Point(417, 489);
            this.listBoxSiparisler.MultiColumn = true;
            this.listBoxSiparisler.Name = "listBoxSiparisler";
            this.listBoxSiparisler.Size = new System.Drawing.Size(395, 130);
            this.listBoxSiparisler.TabIndex = 11;
            this.listBoxSiparisler.SelectedIndexChanged += new System.EventHandler(this.listBoxSiparisler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Menü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "İl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "İlçe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Siparişler";
            // 
            // SiparisLabel
            // 
            this.SiparisLabel.AutoSize = true;
            this.SiparisLabel.Location = new System.Drawing.Point(68, 423);
            this.SiparisLabel.Name = "SiparisLabel";
            this.SiparisLabel.Size = new System.Drawing.Size(0, 13);
            this.SiparisLabel.TabIndex = 16;
            this.SiparisLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yemek Sipariş Sistemi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(836, 634);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SiparisLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSiparisler);
            this.Controls.Add(this.listBoxDistrict);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.ListBox listBoxDistrict;
        private System.Windows.Forms.ListBox listBoxSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SiparisLabel;
        private System.Windows.Forms.Label label7;
    }
}

