
namespace DangNhap
{
    partial class Lop_DaDangKy
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
            this.comboTenLop = new System.Windows.Forms.ComboBox();
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
            this.dataGridView_Lich = new System.Windows.Forms.DataGridView();
            this.MaLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KipHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lich)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 249);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.comboTenLop);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(759, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 218);
            this.panel3.TabIndex = 1;
            // 
            // comboTenLop
            // 
            this.comboTenLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTenLop.FormattingEnabled = true;
            this.comboTenLop.ItemHeight = 21;
            this.comboTenLop.Location = new System.Drawing.Point(58, 106);
            this.comboTenLop.Name = "comboTenLop";
            this.comboTenLop.Size = new System.Drawing.Size(169, 29);
            this.comboTenLop.TabIndex = 1;
            this.comboTenLop.SelectedIndexChanged += new System.EventHandler(this.comboTenLop_SelectedIndexChanged);
            this.comboTenLop.SelectedValueChanged += new System.EventHandler(this.comboTenLop_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(78, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn tên lớp";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
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
            this.textBoxSoTiet.Location = new System.Drawing.Point(435, 153);
            this.textBoxSoTiet.Name = "textBoxSoTiet";
            this.textBoxSoTiet.Size = new System.Drawing.Size(209, 29);
            this.textBoxSoTiet.TabIndex = 21;
            // 
            // textBoxKipHoc
            // 
            this.textBoxKipHoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxKipHoc.Enabled = false;
            this.textBoxKipHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKipHoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxKipHoc.Location = new System.Drawing.Point(435, 82);
            this.textBoxKipHoc.Name = "textBoxKipHoc";
            this.textBoxKipHoc.Size = new System.Drawing.Size(209, 29);
            this.textBoxKipHoc.TabIndex = 20;
            // 
            // textBoxNgayHoc
            // 
            this.textBoxNgayHoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNgayHoc.Enabled = false;
            this.textBoxNgayHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayHoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxNgayHoc.Location = new System.Drawing.Point(435, 11);
            this.textBoxNgayHoc.Name = "textBoxNgayHoc";
            this.textBoxNgayHoc.Size = new System.Drawing.Size(209, 29);
            this.textBoxNgayHoc.TabIndex = 19;
            // 
            // textBoxMaLichHoc
            // 
            this.textBoxMaLichHoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMaLichHoc.Enabled = false;
            this.textBoxMaLichHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLichHoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaLichHoc.Location = new System.Drawing.Point(118, 153);
            this.textBoxMaLichHoc.Name = "textBoxMaLichHoc";
            this.textBoxMaLichHoc.Size = new System.Drawing.Size(209, 29);
            this.textBoxMaLichHoc.TabIndex = 18;
            // 
            // textBox1MaLMH
            // 
            this.textBox1MaLMH.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1MaLMH.Enabled = false;
            this.textBox1MaLMH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1MaLMH.ForeColor = System.Drawing.Color.Black;
            this.textBox1MaLMH.Location = new System.Drawing.Point(110, 82);
            this.textBox1MaLMH.Name = "textBox1MaLMH";
            this.textBox1MaLMH.Size = new System.Drawing.Size(209, 29);
            this.textBox1MaLMH.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(345, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số tiết";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(345, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kíp học";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(328, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày học";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã lịch học";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã LMH";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxHoTen.Enabled = false;
            this.textBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxHoTen.Location = new System.Drawing.Point(108, 11);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(209, 29);
            this.textBoxHoTen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên GV";
            // 
            // dataGridView_Lich
            // 
            this.dataGridView_Lich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Lich.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Lich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Lich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichHoc,
            this.MALMH,
            this.NgayHoc,
            this.KipHoc,
            this.SoTiet,
            this.HoTenGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Lich.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Lich.Location = new System.Drawing.Point(25, 265);
            this.dataGridView_Lich.Name = "dataGridView_Lich";
            this.dataGridView_Lich.RowHeadersWidth = 51;
            this.dataGridView_Lich.RowTemplate.Height = 24;
            this.dataGridView_Lich.Size = new System.Drawing.Size(1082, 436);
            this.dataGridView_Lich.TabIndex = 1;
            this.dataGridView_Lich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lich_CellClick);
            // 
            // MaLichHoc
            // 
            this.MaLichHoc.DataPropertyName = "MaLichHoc";
            this.MaLichHoc.HeaderText = "Mã Lịch Học";
            this.MaLichHoc.MinimumWidth = 6;
            this.MaLichHoc.Name = "MaLichHoc";
            this.MaLichHoc.Width = 170;
            // 
            // MALMH
            // 
            this.MALMH.DataPropertyName = "MALMH";
            this.MALMH.HeaderText = "Mã lớp học";
            this.MALMH.MinimumWidth = 6;
            this.MALMH.Name = "MALMH";
            this.MALMH.Width = 170;
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
            this.KipHoc.Width = 130;
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
            this.HoTenGV.HeaderText = "Giáo Viên";
            this.HoTenGV.MinimumWidth = 6;
            this.HoTenGV.Name = "HoTenGV";
            this.HoTenGV.Width = 229;
            // 
            // Lop_DaDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataGridView_Lich);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(226, -1);
            this.Name = "Lop_DaDangKy";
            this.Size = new System.Drawing.Size(1372, 801);
            this.Load += new System.EventHandler(this.Lop_DaDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_Lich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTenLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSoTiet;
        private System.Windows.Forms.TextBox textBoxKipHoc;
        private System.Windows.Forms.TextBox textBoxNgayHoc;
        private System.Windows.Forms.TextBox textBoxMaLichHoc;
        private System.Windows.Forms.TextBox textBox1MaLMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KipHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV;
    }
}
