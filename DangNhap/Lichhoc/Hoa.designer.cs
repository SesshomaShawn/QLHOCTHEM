namespace DangNhap
{
    partial class Hoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.KipHocHH = new System.Windows.Forms.TextBox();
            this.MaLHHH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GVHH = new System.Windows.Forms.TextBox();
            this.sotietHH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MaLHH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtViewhoa = new System.Windows.Forms.DataGridView();
            this.MaLH_Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLMH_Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc_Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KipHoc_Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet_Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV_Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpHoa = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 313);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbHoa);
            this.panel3.Location = new System.Drawing.Point(1132, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 172);
            this.panel3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp";
            // 
            // cbbHoa
            // 
            this.cbbHoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHoa.FormattingEnabled = true;
            this.cbbHoa.Location = new System.Drawing.Point(25, 88);
            this.cbbHoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbHoa.Name = "cbbHoa";
            this.cbbHoa.Size = new System.Drawing.Size(195, 34);
            this.cbbHoa.TabIndex = 1;
            this.cbbHoa.SelectedIndexChanged += new System.EventHandler(this.CbbHoa_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtpHoa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.KipHocHH);
            this.panel2.Controls.Add(this.MaLHHH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GVHH);
            this.panel2.Controls.Add(this.sotietHH);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.MaLHH);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(63, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 172);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giáo viên   ";
            // 
            // KipHocHH
            // 
            this.KipHocHH.Enabled = false;
            this.KipHocHH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KipHocHH.Location = new System.Drawing.Point(552, 101);
            this.KipHocHH.Margin = new System.Windows.Forms.Padding(4);
            this.KipHocHH.Name = "KipHocHH";
            this.KipHocHH.Size = new System.Drawing.Size(166, 34);
            this.KipHocHH.TabIndex = 12;
            // 
            // MaLHHH
            // 
            this.MaLHHH.Enabled = false;
            this.MaLHHH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLHHH.Location = new System.Drawing.Point(950, 39);
            this.MaLHHH.Margin = new System.Windows.Forms.Padding(4);
            this.MaLHHH.Name = "MaLHHH";
            this.MaLHHH.Size = new System.Drawing.Size(166, 34);
            this.MaLHHH.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(433, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kíp học       ";
            // 
            // GVHH
            // 
            this.GVHH.Enabled = false;
            this.GVHH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVHH.Location = new System.Drawing.Point(190, 39);
            this.GVHH.Margin = new System.Windows.Forms.Padding(4);
            this.GVHH.Name = "GVHH";
            this.GVHH.Size = new System.Drawing.Size(220, 34);
            this.GVHH.TabIndex = 17;
            // 
            // sotietHH
            // 
            this.sotietHH.Enabled = false;
            this.sotietHH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotietHH.Location = new System.Drawing.Point(950, 101);
            this.sotietHH.Margin = new System.Windows.Forms.Padding(4);
            this.sotietHH.Name = "sotietHH";
            this.sotietHH.Size = new System.Drawing.Size(166, 34);
            this.sotietHH.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(798, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã lịch học ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(41, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã LMH    ";
            // 
            // MaLHH
            // 
            this.MaLHH.Enabled = false;
            this.MaLHH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLHH.Location = new System.Drawing.Point(190, 101);
            this.MaLHH.Margin = new System.Windows.Forms.Padding(4);
            this.MaLHH.Name = "MaLHH";
            this.MaLHH.Size = new System.Drawing.Size(166, 34);
            this.MaLHH.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(798, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số tiết     ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(433, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày học";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(673, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi tiết lịch học môn Hóa học";
            // 
            // dtViewhoa
            // 
            this.dtViewhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtViewhoa.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtViewhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dtViewhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLH_Hoa,
            this.MaLMH_Hoa,
            this.NgayHoc_Hoa,
            this.KipHoc_Hoa,
            this.SoTiet_Hoa,
            this.HoTenGV_Hoa});
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtViewhoa.DefaultCellStyle = dataGridViewCellStyle50;
            this.dtViewhoa.Location = new System.Drawing.Point(43, 338);
            this.dtViewhoa.Margin = new System.Windows.Forms.Padding(2);
            this.dtViewhoa.Name = "dtViewhoa";
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtViewhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.dtViewhoa.RowHeadersVisible = false;
            this.dtViewhoa.RowHeadersWidth = 51;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtViewhoa.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.dtViewhoa.RowTemplate.Height = 24;
            this.dtViewhoa.Size = new System.Drawing.Size(1375, 462);
            this.dtViewhoa.TabIndex = 1;
            this.dtViewhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtViewhoa_CellClick);
            // 
            // MaLH_Hoa
            // 
            this.MaLH_Hoa.DataPropertyName = "MaLichHoc";
            this.MaLH_Hoa.HeaderText = "Mã Lịch Học";
            this.MaLH_Hoa.MinimumWidth = 6;
            this.MaLH_Hoa.Name = "MaLH_Hoa";
            this.MaLH_Hoa.Width = 220;
            // 
            // MaLMH_Hoa
            // 
            this.MaLMH_Hoa.DataPropertyName = "MaLMH";
            this.MaLMH_Hoa.HeaderText = "Mã LMH";
            this.MaLMH_Hoa.MinimumWidth = 6;
            this.MaLMH_Hoa.Name = "MaLMH_Hoa";
            this.MaLMH_Hoa.Width = 170;
            // 
            // NgayHoc_Hoa
            // 
            this.NgayHoc_Hoa.DataPropertyName = "NgayHoc";
            this.NgayHoc_Hoa.HeaderText = "Ngày Học";
            this.NgayHoc_Hoa.MinimumWidth = 6;
            this.NgayHoc_Hoa.Name = "NgayHoc_Hoa";
            this.NgayHoc_Hoa.Width = 220;
            // 
            // KipHoc_Hoa
            // 
            this.KipHoc_Hoa.DataPropertyName = "KipHoc";
            this.KipHoc_Hoa.HeaderText = "Kíp Học";
            this.KipHoc_Hoa.MinimumWidth = 6;
            this.KipHoc_Hoa.Name = "KipHoc_Hoa";
            this.KipHoc_Hoa.Width = 170;
            // 
            // SoTiet_Hoa
            // 
            this.SoTiet_Hoa.DataPropertyName = "SoTiet";
            this.SoTiet_Hoa.HeaderText = "Số Tiết";
            this.SoTiet_Hoa.MinimumWidth = 6;
            this.SoTiet_Hoa.Name = "SoTiet_Hoa";
            this.SoTiet_Hoa.Width = 170;
            // 
            // HoTenGV_Hoa
            // 
            this.HoTenGV_Hoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTenGV_Hoa.DataPropertyName = "HoTenGV";
            this.HoTenGV_Hoa.HeaderText = "Giáo Viên ";
            this.HoTenGV_Hoa.MinimumWidth = 6;
            this.HoTenGV_Hoa.Name = "HoTenGV_Hoa";
            // 
            // dtpHoa
            // 
            this.dtpHoa.Enabled = false;
            this.dtpHoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoa.Location = new System.Drawing.Point(552, 39);
            this.dtpHoa.Name = "dtpHoa";
            this.dtpHoa.Size = new System.Drawing.Size(180, 32);
            this.dtpHoa.TabIndex = 18;
            // 
            // Hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.dtViewhoa);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hoa";
            this.Size = new System.Drawing.Size(1434, 818);
            this.Load += new System.EventHandler(this.Hoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtViewhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GVHH;
        private System.Windows.Forms.TextBox MaLHH;
        private System.Windows.Forms.TextBox MaLHHH;
        private System.Windows.Forms.TextBox sotietHH;
        private System.Windows.Forms.TextBox KipHocHH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLH_Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLMH_Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc_Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KipHoc_Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet_Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV_Hoa;
        private System.Windows.Forms.DateTimePicker dtpHoa;
    }
}
