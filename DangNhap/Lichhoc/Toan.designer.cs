namespace DangNhap
{
    partial class Lichhoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTenlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Tiet_Toan = new System.Windows.Forms.TextBox();
            this.LH_Toan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GV_Toan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Kip_Toan = new System.Windows.Forms.TextBox();
            this.ML_Toan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtViewToan = new System.Windows.Forms.DataGridView();
            this.MaLH_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLMH_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KipHoc_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpToan = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtViewToan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbbTenlop);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1132, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 172);
            this.panel3.TabIndex = 17;
            // 
            // cbbTenlop
            // 
            this.cbbTenlop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenlop.FormattingEnabled = true;
            this.cbbTenlop.Location = new System.Drawing.Point(25, 88);
            this.cbbTenlop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenlop.Name = "cbbTenlop";
            this.cbbTenlop.Size = new System.Drawing.Size(195, 34);
            this.cbbTenlop.TabIndex = 1;
            this.cbbTenlop.SelectedIndexChanged += new System.EventHandler(this.CbbTenlop_SelectedIndexChanged);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtpToan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Tiet_Toan);
            this.panel2.Controls.Add(this.LH_Toan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GV_Toan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Kip_Toan);
            this.panel2.Controls.Add(this.ML_Toan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(63, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 172);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giáo viên   ";
            // 
            // Tiet_Toan
            // 
            this.Tiet_Toan.Enabled = false;
            this.Tiet_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiet_Toan.Location = new System.Drawing.Point(950, 101);
            this.Tiet_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.Tiet_Toan.Name = "Tiet_Toan";
            this.Tiet_Toan.Size = new System.Drawing.Size(166, 34);
            this.Tiet_Toan.TabIndex = 10;
            // 
            // LH_Toan
            // 
            this.LH_Toan.Enabled = false;
            this.LH_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LH_Toan.Location = new System.Drawing.Point(950, 39);
            this.LH_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.LH_Toan.Name = "LH_Toan";
            this.LH_Toan.Size = new System.Drawing.Size(166, 34);
            this.LH_Toan.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(798, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số tiết         ";
            // 
            // GV_Toan
            // 
            this.GV_Toan.Enabled = false;
            this.GV_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV_Toan.Location = new System.Drawing.Point(190, 36);
            this.GV_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.GV_Toan.Name = "GV_Toan";
            this.GV_Toan.Size = new System.Drawing.Size(220, 34);
            this.GV_Toan.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(798, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã lịch học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(41, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã LMH    ";
            // 
            // Kip_Toan
            // 
            this.Kip_Toan.Enabled = false;
            this.Kip_Toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kip_Toan.Location = new System.Drawing.Point(554, 101);
            this.Kip_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.Kip_Toan.Name = "Kip_Toan";
            this.Kip_Toan.Size = new System.Drawing.Size(166, 34);
            this.Kip_Toan.TabIndex = 11;
            // 
            // ML_Toan
            // 
            this.ML_Toan.Enabled = false;
            this.ML_Toan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ML_Toan.Location = new System.Drawing.Point(190, 101);
            this.ML_Toan.Margin = new System.Windows.Forms.Padding(2);
            this.ML_Toan.Name = "ML_Toan";
            this.ML_Toan.Size = new System.Drawing.Size(166, 32);
            this.ML_Toan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(432, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(433, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kíp học   ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(673, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chi tiết lịch học môn Toán";
            // 
            // DtViewToan
            // 
            this.DtViewToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtViewToan.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtViewToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.DtViewToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtViewToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLH_Toan,
            this.MaLMH_Toan,
            this.NgayHoc_Toan,
            this.KipHoc_Toan,
            this.SoTiet_Toan,
            this.HoTenGV_Toan});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtViewToan.DefaultCellStyle = dataGridViewCellStyle33;
            this.DtViewToan.Location = new System.Drawing.Point(43, 338);
            this.DtViewToan.Margin = new System.Windows.Forms.Padding(2);
            this.DtViewToan.Name = "DtViewToan";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtViewToan.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.DtViewToan.RowHeadersVisible = false;
            this.DtViewToan.RowHeadersWidth = 51;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtViewToan.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.DtViewToan.RowTemplate.Height = 24;
            this.DtViewToan.Size = new System.Drawing.Size(1375, 462);
            this.DtViewToan.TabIndex = 2;
            this.DtViewToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtViewToan_CellClick);
            // 
            // MaLH_Toan
            // 
            this.MaLH_Toan.DataPropertyName = "MaLichHoc";
            this.MaLH_Toan.HeaderText = "Mã Lịch học";
            this.MaLH_Toan.MinimumWidth = 6;
            this.MaLH_Toan.Name = "MaLH_Toan";
            this.MaLH_Toan.Width = 220;
            // 
            // MaLMH_Toan
            // 
            this.MaLMH_Toan.DataPropertyName = "MaLMH";
            this.MaLMH_Toan.HeaderText = "Mã LMH";
            this.MaLMH_Toan.MinimumWidth = 6;
            this.MaLMH_Toan.Name = "MaLMH_Toan";
            this.MaLMH_Toan.Width = 180;
            // 
            // NgayHoc_Toan
            // 
            this.NgayHoc_Toan.DataPropertyName = "NgayHoc";
            dataGridViewCellStyle32.Format = "dd/MM/yyyy";
            this.NgayHoc_Toan.DefaultCellStyle = dataGridViewCellStyle32;
            this.NgayHoc_Toan.HeaderText = "Ngày Học";
            this.NgayHoc_Toan.MinimumWidth = 6;
            this.NgayHoc_Toan.Name = "NgayHoc_Toan";
            this.NgayHoc_Toan.Width = 220;
            // 
            // KipHoc_Toan
            // 
            this.KipHoc_Toan.DataPropertyName = "KipHoc";
            this.KipHoc_Toan.HeaderText = "Kíp học";
            this.KipHoc_Toan.MinimumWidth = 6;
            this.KipHoc_Toan.Name = "KipHoc_Toan";
            this.KipHoc_Toan.Width = 170;
            // 
            // SoTiet_Toan
            // 
            this.SoTiet_Toan.DataPropertyName = "SoTiet";
            this.SoTiet_Toan.HeaderText = "Số Tiết";
            this.SoTiet_Toan.MinimumWidth = 6;
            this.SoTiet_Toan.Name = "SoTiet_Toan";
            this.SoTiet_Toan.Width = 170;
            // 
            // HoTenGV_Toan
            // 
            this.HoTenGV_Toan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTenGV_Toan.DataPropertyName = "HoTenGV";
            this.HoTenGV_Toan.HeaderText = "Giáo viên";
            this.HoTenGV_Toan.MinimumWidth = 6;
            this.HoTenGV_Toan.Name = "HoTenGV_Toan";
            // 
            // dtpToan
            // 
            this.dtpToan.Enabled = false;
            this.dtpToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToan.Location = new System.Drawing.Point(554, 39);
            this.dtpToan.Name = "dtpToan";
            this.dtpToan.Size = new System.Drawing.Size(172, 32);
            this.dtpToan.TabIndex = 16;
            // 
            // Lichhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.DtViewToan);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lichhoc";
            this.Size = new System.Drawing.Size(1434, 818);
            this.Load += new System.EventHandler(this.Lichhoc_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLH_Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLMH_Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc_Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KipHoc_Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet_Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV_Toan;
        private System.Windows.Forms.DateTimePicker dtpToan;
    }
}
