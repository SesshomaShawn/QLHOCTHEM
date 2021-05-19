namespace DangNhap
{
    partial class LichDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTenlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LH_Toan = new System.Windows.Forms.TextBox();
            this.GV_Toan = new System.Windows.Forms.TextBox();
            this.Tiet_Toan = new System.Windows.Forms.TextBox();
            this.Ngay_Toan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Kip_Toan = new System.Windows.Forms.TextBox();
            this.ML_Toan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtViewToan = new System.Windows.Forms.DataGridView();
            this.MaLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KipHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtViewToan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(1363, 10);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbbTenlop);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(648, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 152);
            this.panel3.TabIndex = 17;
            // 
            // cbbTenlop
            // 
            this.cbbTenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbTenlop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenlop.FormattingEnabled = true;
            this.cbbTenlop.Location = new System.Drawing.Point(13, 62);
            this.cbbTenlop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenlop.Name = "cbbTenlop";
            this.cbbTenlop.Size = new System.Drawing.Size(164, 28);
            this.cbbTenlop.TabIndex = 1;
            this.cbbTenlop.SelectedIndexChanged += new System.EventHandler(this.CbbTenlop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;

            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LH_Toan);
            this.panel2.Controls.Add(this.GV_Toan);
            this.panel2.Controls.Add(this.Tiet_Toan);
            this.panel2.Controls.Add(this.Ngay_Toan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Kip_Toan);
            this.panel2.Controls.Add(this.ML_Toan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(217, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 152);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giáo viên   ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LH_Toan
            // 
            this.LH_Toan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LH_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LH_Toan.Location = new System.Drawing.Point(781, 78);
            this.LH_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.LH_Toan.Name = "LH_Toan";
            this.LH_Toan.Size = new System.Drawing.Size(138, 29);
            this.LH_Toan.TabIndex = 13;
            this.LH_Toan.TextChanged += new System.EventHandler(this.LH_Toan_TextChanged);
            // 
            // GV_Toan
            // 
            this.GV_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV_Toan.Location = new System.Drawing.Point(158, 33);
            this.GV_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.GV_Toan.Name = "GV_Toan";
            this.GV_Toan.Size = new System.Drawing.Size(138, 29);
            this.GV_Toan.TabIndex = 15;
            this.GV_Toan.TextChanged += new System.EventHandler(this.GV_Toan_TextChanged);
            // 
            // Tiet_Toan
            // 
            this.Tiet_Toan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Tiet_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiet_Toan.Location = new System.Drawing.Point(781, 30);
            this.Tiet_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.Tiet_Toan.Name = "Tiet_Toan";
            this.Tiet_Toan.Size = new System.Drawing.Size(138, 29);
            this.Tiet_Toan.TabIndex = 10;
            this.Tiet_Toan.TextChanged += new System.EventHandler(this.Tiet_Toan_TextChanged);
            // 
            // Ngay_Toan
            // 
            this.Ngay_Toan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ngay_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngay_Toan.Location = new System.Drawing.Point(460, 33);
            this.Ngay_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.Ngay_Toan.Name = "Ngay_Toan";
            this.Ngay_Toan.Size = new System.Drawing.Size(138, 29);
            this.Ngay_Toan.TabIndex = 12;
            this.Ngay_Toan.TextChanged += new System.EventHandler(this.Ngay_Toan_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(670, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã lịch học";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(46, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã LMH    ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(670, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số tiết      ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Kip_Toan
            // 
            this.Kip_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kip_Toan.Location = new System.Drawing.Point(460, 83);
            this.Kip_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.Kip_Toan.Name = "Kip_Toan";
            this.Kip_Toan.Size = new System.Drawing.Size(138, 29);
            this.Kip_Toan.TabIndex = 11;
            this.Kip_Toan.TextChanged += new System.EventHandler(this.Kip_Toan_TextChanged);
            // 
            // ML_Toan
            // 
            this.ML_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ML_Toan.Location = new System.Drawing.Point(158, 80);
            this.ML_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.ML_Toan.Name = "ML_Toan";
            this.ML_Toan.Size = new System.Drawing.Size(138, 29);
            this.ML_Toan.TabIndex = 14;
            this.ML_Toan.TextChanged += new System.EventHandler(this.ML_Toan_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(362, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày học";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(362, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kíp học  ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(705, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chi tiết lịch dạy";
            // 
            // DtViewToan
            // 
            this.DtViewToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtViewToan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtViewToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtViewToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtViewToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichHoc,
            this.MaLMH,
            this.NgayHoc,
            this.KipHoc,
            this.SoTiet,
            this.HoTenGV});

            this.DtViewToan.Location = new System.Drawing.Point(8, 15);
            this.DtViewToan.Margin = new System.Windows.Forms.Padding(2);
            this.DtViewToan.Name = "DtViewToan";
            this.DtViewToan.RowHeadersVisible = false;
            this.DtViewToan.RowHeadersWidth = 51;
            this.DtViewToan.RowTemplate.Height = 24;

            this.DtViewToan.Size = new System.Drawing.Size(1343, 624);
            this.DtViewToan.TabIndex = 2;
            this.DtViewToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtViewToan_CellClick);
            this.DtViewToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtViewToan_CellContentClick);
            // 
            // MaLichHoc
            // 
            this.MaLichHoc.DataPropertyName = "MaLichHoc";
            this.MaLichHoc.HeaderText = "Mã Lịch học";
            this.MaLichHoc.MinimumWidth = 6;
            this.MaLichHoc.Name = "MaLichHoc";
            this.MaLichHoc.Width = 220;
            // 
            // MaLMH
            // 
            this.MaLMH.DataPropertyName = "MaLMH";
            this.MaLMH.HeaderText = "Mã LMH";
            this.MaLMH.MinimumWidth = 6;
            this.MaLMH.Name = "MaLMH";
            this.MaLMH.Width = 170;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NgayHoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayHoc.HeaderText = "Ngày Học";
            this.NgayHoc.MinimumWidth = 6;
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 220;
            // 
            // KipHoc
            // 
            this.KipHoc.DataPropertyName = "KipHoc";
            this.KipHoc.HeaderText = "Kíp học";
            this.KipHoc.MinimumWidth = 6;
            this.KipHoc.Name = "KipHoc";
            this.KipHoc.Width = 160;
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số Tiết";
            this.SoTiet.MinimumWidth = 6;
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Width = 160;
            // 
            // HoTenGV
            // 
            this.HoTenGV.DataPropertyName = "HoTenGV";
            this.HoTenGV.HeaderText = "Giáo viên";
            this.HoTenGV.MinimumWidth = 6;
            this.HoTenGV.Name = "HoTenGV";
            this.HoTenGV.Width = 410;
            // 
            // LichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.DtViewToan);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LichDay";
            this.Size = new System.Drawing.Size(1363, 651);
            this.Load += new System.EventHandler(this.LichDay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtViewToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTenlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtViewToan;
        private System.Windows.Forms.TextBox GV_Toan;
        private System.Windows.Forms.TextBox ML_Toan;
        private System.Windows.Forms.TextBox LH_Toan;
        private System.Windows.Forms.TextBox Ngay_Toan;
        private System.Windows.Forms.TextBox Kip_Toan;
        private System.Windows.Forms.TextBox Tiet_Toan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KipHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV;
    }
}
