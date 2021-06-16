
namespace DangNhap
{
    partial class TimKiemLichHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDay2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDay1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSoTiet = new System.Windows.Forms.TextBox();
            this.textBoxKipHoc = new System.Windows.Forms.TextBox();
            this.textBoxNgayHoc = new System.Windows.Forms.TextBox();
            this.textBoxMaLichHoc = new System.Windows.Forms.TextBox();
            this.textBox1MaLMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTimKiemLichHoc = new System.Windows.Forms.DataGridView();
            this.MaLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KipHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 319);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtpDay2);
            this.panel3.Controls.Add(this.dtpDay1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(702, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 268);
            this.panel3.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(153, 231);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Từ";
            // 
            // dtpDay2
            // 
            this.dtpDay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay2.Location = new System.Drawing.Point(109, 177);
            this.dtpDay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDay2.Name = "dtpDay2";
            this.dtpDay2.Size = new System.Drawing.Size(184, 22);
            this.dtpDay2.TabIndex = 4;
            // 
            // dtpDay1
            // 
            this.dtpDay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay1.Location = new System.Drawing.Point(109, 112);
            this.dtpDay1.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDay1.Name = "dtpDay1";
            this.dtpDay1.Size = new System.Drawing.Size(184, 22);
            this.dtpDay1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn thời gian";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxSoTiet);
            this.panel2.Controls.Add(this.textBoxKipHoc);
            this.panel2.Controls.Add(this.textBoxNgayHoc);
            this.panel2.Controls.Add(this.textBoxMaLichHoc);
            this.panel2.Controls.Add(this.textBox1MaLMH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxHoTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 218);
            this.panel2.TabIndex = 0;
            // 
            // textBoxSoTiet
            // 
            this.textBoxSoTiet.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSoTiet.Enabled = false;
            this.textBoxSoTiet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoTiet.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoTiet.Location = new System.Drawing.Point(580, 188);
            this.textBoxSoTiet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoTiet.Name = "textBoxSoTiet";
            this.textBoxSoTiet.Size = new System.Drawing.Size(277, 35);
            this.textBoxSoTiet.TabIndex = 21;
            // 
            // textBoxKipHoc
            // 
            this.textBoxKipHoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxKipHoc.Enabled = false;
            this.textBoxKipHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKipHoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxKipHoc.Location = new System.Drawing.Point(580, 101);
            this.textBoxKipHoc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKipHoc.Name = "textBoxKipHoc";
            this.textBoxKipHoc.Size = new System.Drawing.Size(277, 35);
            this.textBoxKipHoc.TabIndex = 20;
            // 
            // textBoxNgayHoc
            // 
            this.textBoxNgayHoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNgayHoc.Enabled = false;
            this.textBoxNgayHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayHoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxNgayHoc.Location = new System.Drawing.Point(580, 14);
            this.textBoxNgayHoc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNgayHoc.Name = "textBoxNgayHoc";
            this.textBoxNgayHoc.Size = new System.Drawing.Size(277, 35);
            this.textBoxNgayHoc.TabIndex = 19;
            // 
            // textBoxMaLichHoc
            // 
            this.textBoxMaLichHoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMaLichHoc.Enabled = false;
            this.textBoxMaLichHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLichHoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaLichHoc.Location = new System.Drawing.Point(157, 188);
            this.textBoxMaLichHoc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaLichHoc.Name = "textBoxMaLichHoc";
            this.textBoxMaLichHoc.Size = new System.Drawing.Size(277, 35);
            this.textBoxMaLichHoc.TabIndex = 18;
            // 
            // textBox1MaLMH
            // 
            this.textBox1MaLMH.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1MaLMH.Enabled = false;
            this.textBox1MaLMH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1MaLMH.ForeColor = System.Drawing.Color.Black;
            this.textBox1MaLMH.Location = new System.Drawing.Point(147, 101);
            this.textBox1MaLMH.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1MaLMH.Name = "textBox1MaLMH";
            this.textBox1MaLMH.Size = new System.Drawing.Size(277, 35);
            this.textBox1MaLMH.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(460, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số tiết";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(460, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kíp học";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(437, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày học";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã lịch học";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã LMH";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxHoTen.Enabled = false;
            this.textBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxHoTen.Location = new System.Drawing.Point(144, 14);
            this.textBoxHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(277, 35);
            this.textBoxHoTen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên GV";
            // 
            // dataGridViewTimKiemLichHoc
            // 
            this.dataGridViewTimKiemLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemLichHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichHoc,
            this.TenLMH,
            this.NgayHoc,
            this.KipHoc,
            this.SoTiet,
            this.HoTenGV});
            this.dataGridViewTimKiemLichHoc.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewTimKiemLichHoc.Location = new System.Drawing.Point(33, 326);
            this.dataGridViewTimKiemLichHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTimKiemLichHoc.Name = "dataGridViewTimKiemLichHoc";
            this.dataGridViewTimKiemLichHoc.RowHeadersWidth = 51;
            this.dataGridViewTimKiemLichHoc.Size = new System.Drawing.Size(1000, 537);
            this.dataGridViewTimKiemLichHoc.TabIndex = 3;
            this.dataGridViewTimKiemLichHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimKiemLichHoc_CellClick_1);
            this.dataGridViewTimKiemLichHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimKiemLichHoc_CellContentClick_1);
            // 
            // MaLichHoc
            // 
            this.MaLichHoc.DataPropertyName = "MaLichHoc";
            this.MaLichHoc.HeaderText = "Mã Lịch Học";
            this.MaLichHoc.MinimumWidth = 6;
            this.MaLichHoc.Name = "MaLichHoc";
            this.MaLichHoc.Width = 170;
            // 
            // TenLMH
            // 
            this.TenLMH.DataPropertyName = "TenLMH";
            this.TenLMH.HeaderText = "Tên LMH";
            this.TenLMH.MinimumWidth = 6;
            this.TenLMH.Name = "TenLMH";
            this.TenLMH.Width = 170;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngày Học";
            this.NgayHoc.MinimumWidth = 6;
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 170;
            // 
            // KipHoc
            // 
            this.KipHoc.DataPropertyName = "KipHoc";
            this.KipHoc.HeaderText = "Kíp Học";
            this.KipHoc.MinimumWidth = 6;
            this.KipHoc.Name = "KipHoc";
            this.KipHoc.Width = 170;
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số Tiết";
            this.SoTiet.MinimumWidth = 6;
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Width = 170;
            // 
            // HoTenGV
            // 
            this.HoTenGV.DataPropertyName = "HoTenGV";
            this.HoTenGV.HeaderText = "Giáo Viên";
            this.HoTenGV.MinimumWidth = 6;
            this.HoTenGV.Name = "HoTenGV";
            this.HoTenGV.Width = 170;
            // 
            // TimKiemLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.dataGridViewTimKiemLichHoc);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Location = new System.Drawing.Point(226, -1);
            this.Name = "TimKiemLichHoc";
            this.Size = new System.Drawing.Size(1372, 801);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemLichHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDay2;
        private System.Windows.Forms.DateTimePicker dtpDay1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSoTiet;
        private System.Windows.Forms.TextBox textBoxKipHoc;
        private System.Windows.Forms.TextBox textBoxNgayHoc;
        private System.Windows.Forms.TextBox textBoxMaLichHoc;
        private System.Windows.Forms.TextBox textBox1MaLMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTimKiemLichHoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KipHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV;
    }
}
