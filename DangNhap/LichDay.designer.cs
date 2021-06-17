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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelChitiet = new System.Windows.Forms.Panel();
            this.textBoxSoTiet = new System.Windows.Forms.TextBox();
            this.textBoxKip = new System.Windows.Forms.TextBox();
            this.textBoxNgayHoc = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panelChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lich)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelChitiet);
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 249);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.cbbTenLop);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(759, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 218);
            this.panel3.TabIndex = 1;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(58, 106);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(169, 28);
            this.cbbTenLop.TabIndex = 1;
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn tên lớp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChitiet
            // 
            this.panelChitiet.BackColor = System.Drawing.Color.LightBlue;
            this.panelChitiet.Controls.Add(this.textBoxSoTiet);
            this.panelChitiet.Controls.Add(this.textBoxKip);
            this.panelChitiet.Controls.Add(this.textBoxNgayHoc);
            this.panelChitiet.Controls.Add(this.textBoxHoTen);
            this.panelChitiet.Controls.Add(this.label4);
            this.panelChitiet.Controls.Add(this.label3);
            this.panelChitiet.Controls.Add(this.label2);
            this.panelChitiet.Controls.Add(this.label1);
            this.panelChitiet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChitiet.Location = new System.Drawing.Point(25, 16);
            this.panelChitiet.Name = "panelChitiet";
            this.panelChitiet.Size = new System.Drawing.Size(671, 218);
            this.panelChitiet.TabIndex = 0;
            // 
            // textBoxSoTiet
            // 
            this.textBoxSoTiet.Enabled = false;
            this.textBoxSoTiet.Location = new System.Drawing.Point(442, 118);
            this.textBoxSoTiet.Name = "textBoxSoTiet";
            this.textBoxSoTiet.ReadOnly = true;
            this.textBoxSoTiet.Size = new System.Drawing.Size(209, 29);
            this.textBoxSoTiet.TabIndex = 13;
            // 
            // textBoxKip
            // 
            this.textBoxKip.Enabled = false;
            this.textBoxKip.Location = new System.Drawing.Point(442, 48);
            this.textBoxKip.Name = "textBoxKip";
            this.textBoxKip.ReadOnly = true;
            this.textBoxKip.Size = new System.Drawing.Size(209, 29);
            this.textBoxKip.TabIndex = 12;
            // 
            // textBoxNgayHoc
            // 
            this.textBoxNgayHoc.Enabled = false;
            this.textBoxNgayHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayHoc.Location = new System.Drawing.Point(110, 118);
            this.textBoxNgayHoc.Name = "textBoxNgayHoc";
            this.textBoxNgayHoc.ReadOnly = true;
            this.textBoxNgayHoc.Size = new System.Drawing.Size(209, 29);
            this.textBoxNgayHoc.TabIndex = 11;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Enabled = false;
            this.textBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxHoTen.Location = new System.Drawing.Point(110, 48);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.ReadOnly = true;
            this.textBoxHoTen.Size = new System.Drawing.Size(209, 29);
            this.textBoxHoTen.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số tiết:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(335, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kíp học:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày học:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên GV:";
            // 
            // dataGridView_Lich
            // 
            this.dataGridView_Lich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Lich.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Lich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichHoc,
            this.MALMH,
            this.NgayHoc,
            this.KipHoc,
            this.SoTiet,
            this.HoTenGV});
            this.dataGridView_Lich.Location = new System.Drawing.Point(25, 265);
            this.dataGridView_Lich.Name = "dataGridView_Lich";
            this.dataGridView_Lich.ReadOnly = true;
            this.dataGridView_Lich.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dataGridView_Lich.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Lich.RowTemplate.Height = 24;
            this.dataGridView_Lich.Size = new System.Drawing.Size(1082, 436);
            this.dataGridView_Lich.TabIndex = 1;
            this.dataGridView_Lich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lich_CellClick);
            // 
            // MaLichHoc
            // 
            this.MaLichHoc.DataPropertyName = "MaLichHoc";
            this.MaLichHoc.HeaderText = "Mã lịch học";
            this.MaLichHoc.Name = "MaLichHoc";
            this.MaLichHoc.ReadOnly = true;
            this.MaLichHoc.Width = 170;
            // 
            // MALMH
            // 
            this.MALMH.DataPropertyName = "MALMH";
            this.MALMH.HeaderText = "Mã lớp học";
            this.MALMH.Name = "MALMH";
            this.MALMH.ReadOnly = true;
            this.MALMH.Width = 170;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngày học";
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.ReadOnly = true;
            this.NgayHoc.Width = 170;
            // 
            // KipHoc
            // 
            this.KipHoc.DataPropertyName = "KipHoc";
            this.KipHoc.HeaderText = "Kíp";
            this.KipHoc.Name = "KipHoc";
            this.KipHoc.ReadOnly = true;
            this.KipHoc.Width = 130;
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số tiết";
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.ReadOnly = true;
            this.SoTiet.Width = 160;
            // 
            // HoTenGV
            // 
            this.HoTenGV.DataPropertyName = "HoTenGV";
            this.HoTenGV.HeaderText = "Họ tên GV";
            this.HoTenGV.Name = "HoTenGV";
            this.HoTenGV.ReadOnly = true;
            this.HoTenGV.Width = 229;
            // 
            // LichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataGridView_Lich);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(226, -1);
            this.Name = "LichDay";
            this.Size = new System.Drawing.Size(1372, 801);
            this.Load += new System.EventHandler(this.LichDay_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelChitiet.ResumeLayout(false);
            this.panelChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChitiet;
        private System.Windows.Forms.DataGridView dataGridView_Lich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KipHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV;
        private System.Windows.Forms.TextBox textBoxSoTiet;
        private System.Windows.Forms.TextBox textBoxKip;
        private System.Windows.Forms.TextBox textBoxNgayHoc;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTenLop;
    }
}
