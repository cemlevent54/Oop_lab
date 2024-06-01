namespace _152120171010_152120211071_19
{
    partial class labeluser1
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
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user1lastpoint = new System.Windows.Forms.Label();
            this.user2lastpoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "OYUN";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(543, 268);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(88, 35);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "sonuc";
            this.label2.Visible = false;
            // 
            // user1lastpoint
            // 
            this.user1lastpoint.AutoSize = true;
            this.user1lastpoint.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1lastpoint.Location = new System.Drawing.Point(948, 120);
            this.user1lastpoint.Name = "user1lastpoint";
            this.user1lastpoint.Size = new System.Drawing.Size(120, 28);
            this.user1lastpoint.TabIndex = 3;
            this.user1lastpoint.Text = "labeluser1";
            this.user1lastpoint.Visible = false;
            // 
            // user2lastpoint
            // 
            this.user2lastpoint.AutoSize = true;
            this.user2lastpoint.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2lastpoint.Location = new System.Drawing.Point(948, 180);
            this.user2lastpoint.Name = "user2lastpoint";
            this.user2lastpoint.Size = new System.Drawing.Size(120, 28);
            this.user2lastpoint.TabIndex = 4;
            this.user2lastpoint.Text = "labeluser2";
            this.user2lastpoint.Visible = false;
            // 
            // labeluser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 593);
            this.Controls.Add(this.user2lastpoint);
            this.Controls.Add(this.user1lastpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Name = "labeluser1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "labeluser1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label user1lastpoint;
        public System.Windows.Forms.Label user2lastpoint;
    }
}

