namespace DangNhap
{
    partial class FormSaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaoLuu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_browser1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_browser2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Controls.Add(this.btn_browser1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Location);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(601, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu";
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.IndianRed;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backup.ForeColor = System.Drawing.Color.Black;
            this.btn_backup.Location = new System.Drawing.Point(486, 76);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(96, 33);
            this.btn_backup.TabIndex = 3;
            this.btn_backup.Text = "Sao lưu";
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_browser1
            // 
            this.btn_browser1.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_browser1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_browser1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browser1.ForeColor = System.Drawing.Color.Black;
            this.btn_browser1.Location = new System.Drawing.Point(486, 40);
            this.btn_browser1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_browser1.Name = "btn_browser1";
            this.btn_browser1.Size = new System.Drawing.Size(96, 32);
            this.btn_browser1.TabIndex = 2;
            this.btn_browser1.Text = "Chọn nơi lưu";
            this.btn_browser1.UseVisualStyleBackColor = false;
            this.btn_browser1.Click += new System.EventHandler(this.btn_browser1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(10, 46);
            this.Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(86, 19);
            this.Location.TabIndex = 0;
            this.Location.Text = "Đường dẫn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.btn_browser2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(22, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(601, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khôi phục";
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_restore.ForeColor = System.Drawing.Color.Black;
            this.btn_restore.Location = new System.Drawing.Point(486, 81);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(2);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(96, 34);
            this.btn_restore.TabIndex = 3;
            this.btn_restore.Text = "Khôi phục";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_browser2
            // 
            this.btn_browser2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_browser2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_browser2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browser2.ForeColor = System.Drawing.Color.Black;
            this.btn_browser2.Location = new System.Drawing.Point(486, 45);
            this.btn_browser2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_browser2.Name = "btn_browser2";
            this.btn_browser2.Size = new System.Drawing.Size(96, 32);
            this.btn_browser2.TabIndex = 2;
            this.btn_browser2.Text = "Chọn nơi lưu";
            this.btn_browser2.UseVisualStyleBackColor = false;
            this.btn_browser2.Click += new System.EventHandler(this.btn_browser2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // FormSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao Lưu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_browser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_browser2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}