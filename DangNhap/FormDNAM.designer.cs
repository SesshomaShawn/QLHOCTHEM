namespace DangNhap
{
     partial class FormDNAM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDNAM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIntro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.pn_LichHoc = new System.Windows.Forms.Panel();
            this.btn_ChemistryAD = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_EnglishAD = new System.Windows.Forms.Button();
            this.btn_PhysicAD = new System.Windows.Forms.Button();
            this.btn_MathAD = new System.Windows.Forms.Button();
            this.XemLichHoc = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thucTapCSDLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_LichHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucTapCSDLDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbIntro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 711);
            this.panel1.TabIndex = 4;
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIntro.ForeColor = System.Drawing.Color.Black;
            this.lbIntro.Location = new System.Drawing.Point(34, 91);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(155, 22);
            this.lbIntro.TabIndex = 21;
            this.lbIntro.Text = "Xin chào, Admin!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_SaoLuu);
            this.panel2.Controls.Add(this.btnHocSinh);
            this.panel2.Controls.Add(this.pn_LichHoc);
            this.panel2.Controls.Add(this.XemLichHoc);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnGiaoVien);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(2, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 593);
            this.panel2.TabIndex = 20;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_logout.Location = new System.Drawing.Point(0, 511);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(229, 44);
            this.btn_logout.TabIndex = 22;
            this.btn_logout.Text = "    Đăng xuất ";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            this.btn_logout.MouseEnter += new System.EventHandler(this.btn_logout_MouseEnter);
            this.btn_logout.MouseLeave += new System.EventHandler(this.btn_logout_MouseLeave);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(0, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "   Thống kê";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SaoLuu.FlatAppearance.BorderSize = 0;
            this.btn_SaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaoLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SaoLuu.ForeColor = System.Drawing.Color.Black;
            this.btn_SaoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaoLuu.Image")));
            this.btn_SaoLuu.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_SaoLuu.Location = new System.Drawing.Point(0, 423);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(229, 44);
            this.btn_SaoLuu.TabIndex = 16;
            this.btn_SaoLuu.Text = "   Sao lưu ";
            this.btn_SaoLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaoLuu.UseVisualStyleBackColor = false;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            this.btn_SaoLuu.MouseEnter += new System.EventHandler(this.btn_SaoLuu_MouseEnter);
            this.btn_SaoLuu.MouseLeave += new System.EventHandler(this.btn_SaoLuu_MouseLeave);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocSinh.FlatAppearance.BorderSize = 0;
            this.btnHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocSinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHocSinh.ForeColor = System.Drawing.Color.Black;
            this.btnHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocSinh.Image")));
            this.btnHocSinh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnHocSinh.Location = new System.Drawing.Point(0, 379);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(229, 44);
            this.btnHocSinh.TabIndex = 14;
            this.btnHocSinh.Text = "   Học sinh";
            this.btnHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            this.btnHocSinh.MouseEnter += new System.EventHandler(this.btnHocSinh_MouseEnter);
            this.btnHocSinh.MouseLeave += new System.EventHandler(this.btnHocSinh_MouseLeave);
            // 
            // pn_LichHoc
            // 
            this.pn_LichHoc.Controls.Add(this.btn_ChemistryAD);
            this.pn_LichHoc.Controls.Add(this.button9);
            this.pn_LichHoc.Controls.Add(this.btn_EnglishAD);
            this.pn_LichHoc.Controls.Add(this.btn_PhysicAD);
            this.pn_LichHoc.Controls.Add(this.btn_MathAD);
            this.pn_LichHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_LichHoc.Location = new System.Drawing.Point(0, 176);
            this.pn_LichHoc.Margin = new System.Windows.Forms.Padding(2);
            this.pn_LichHoc.Name = "pn_LichHoc";
            this.pn_LichHoc.Size = new System.Drawing.Size(229, 203);
            this.pn_LichHoc.TabIndex = 21;
            // 
            // btn_ChemistryAD
            // 
            this.btn_ChemistryAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChemistryAD.FlatAppearance.BorderSize = 0;
            this.btn_ChemistryAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChemistryAD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ChemistryAD.ForeColor = System.Drawing.Color.Black;
            this.btn_ChemistryAD.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChemistryAD.Image")));
            this.btn_ChemistryAD.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_ChemistryAD.Location = new System.Drawing.Point(0, 164);
            this.btn_ChemistryAD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChemistryAD.Name = "btn_ChemistryAD";
            this.btn_ChemistryAD.Size = new System.Drawing.Size(229, 41);
            this.btn_ChemistryAD.TabIndex = 4;
            this.btn_ChemistryAD.Text = "      Hóa học    ";
            this.btn_ChemistryAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChemistryAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChemistryAD.UseVisualStyleBackColor = false;
            this.btn_ChemistryAD.Click += new System.EventHandler(this.btn_ChemistryAD_Click);
            this.btn_ChemistryAD.MouseEnter += new System.EventHandler(this.btn_ChemistryAD_MouseEnter);
            this.btn_ChemistryAD.MouseLeave += new System.EventHandler(this.btn_ChemistryAD_MouseLeave);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button9.Location = new System.Drawing.Point(0, 123);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(229, 41);
            this.button9.TabIndex = 3;
            this.button9.Text = "     Văn học     ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseEnter += new System.EventHandler(this.button9_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button9_MouseLeave);
            // 
            // btn_EnglishAD
            // 
            this.btn_EnglishAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EnglishAD.FlatAppearance.BorderSize = 0;
            this.btn_EnglishAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EnglishAD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EnglishAD.ForeColor = System.Drawing.Color.Black;
            this.btn_EnglishAD.Image = ((System.Drawing.Image)(resources.GetObject("btn_EnglishAD.Image")));
            this.btn_EnglishAD.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_EnglishAD.Location = new System.Drawing.Point(0, 82);
            this.btn_EnglishAD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EnglishAD.Name = "btn_EnglishAD";
            this.btn_EnglishAD.Size = new System.Drawing.Size(229, 41);
            this.btn_EnglishAD.TabIndex = 2;
            this.btn_EnglishAD.Text = "    Tiếng Anh   ";
            this.btn_EnglishAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EnglishAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EnglishAD.UseVisualStyleBackColor = false;
            this.btn_EnglishAD.Click += new System.EventHandler(this.btn_EnglishAD_Click);
            this.btn_EnglishAD.MouseEnter += new System.EventHandler(this.btn_EnglishAD_MouseEnter);
            this.btn_EnglishAD.MouseLeave += new System.EventHandler(this.btn_EnglishAD_MouseLeave);
            // 
            // btn_PhysicAD
            // 
            this.btn_PhysicAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PhysicAD.FlatAppearance.BorderSize = 0;
            this.btn_PhysicAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhysicAD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_PhysicAD.ForeColor = System.Drawing.Color.Black;
            this.btn_PhysicAD.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhysicAD.Image")));
            this.btn_PhysicAD.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_PhysicAD.Location = new System.Drawing.Point(0, 41);
            this.btn_PhysicAD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PhysicAD.Name = "btn_PhysicAD";
            this.btn_PhysicAD.Size = new System.Drawing.Size(229, 41);
            this.btn_PhysicAD.TabIndex = 1;
            this.btn_PhysicAD.Text = "    Vật lí           ";
            this.btn_PhysicAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PhysicAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PhysicAD.UseVisualStyleBackColor = false;
            this.btn_PhysicAD.Click += new System.EventHandler(this.btn_PhysicAD_Click);
            this.btn_PhysicAD.MouseEnter += new System.EventHandler(this.btn_PhysicAD_MouseEnter);
            this.btn_PhysicAD.MouseLeave += new System.EventHandler(this.btn_PhysicAD_MouseLeave);
            // 
            // btn_MathAD
            // 
            this.btn_MathAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MathAD.FlatAppearance.BorderSize = 0;
            this.btn_MathAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MathAD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_MathAD.ForeColor = System.Drawing.Color.Black;
            this.btn_MathAD.Image = ((System.Drawing.Image)(resources.GetObject("btn_MathAD.Image")));
            this.btn_MathAD.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_MathAD.Location = new System.Drawing.Point(0, 0);
            this.btn_MathAD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MathAD.Name = "btn_MathAD";
            this.btn_MathAD.Size = new System.Drawing.Size(229, 41);
            this.btn_MathAD.TabIndex = 0;
            this.btn_MathAD.Text = "    Toán học    ";
            this.btn_MathAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MathAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MathAD.UseVisualStyleBackColor = false;
            this.btn_MathAD.Click += new System.EventHandler(this.button2_Click);
            this.btn_MathAD.MouseEnter += new System.EventHandler(this.btn_MathAD_MouseEnter);
            this.btn_MathAD.MouseLeave += new System.EventHandler(this.btn_MathAD_MouseLeave);
            // 
            // XemLichHoc
            // 
            this.XemLichHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.XemLichHoc.FlatAppearance.BorderSize = 0;
            this.XemLichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XemLichHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.XemLichHoc.ForeColor = System.Drawing.Color.Black;
            this.XemLichHoc.Image = ((System.Drawing.Image)(resources.GetObject("XemLichHoc.Image")));
            this.XemLichHoc.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.XemLichHoc.Location = new System.Drawing.Point(0, 132);
            this.XemLichHoc.Name = "XemLichHoc";
            this.XemLichHoc.Size = new System.Drawing.Size(229, 44);
            this.XemLichHoc.TabIndex = 19;
            this.XemLichHoc.Text = "   Lịch học ";
            this.XemLichHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XemLichHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XemLichHoc.UseVisualStyleBackColor = false;
            this.XemLichHoc.Click += new System.EventHandler(this.btnXemLichHoc);
            this.XemLichHoc.MouseEnter += new System.EventHandler(this.XemLichHoc_MouseEnter);
            this.XemLichHoc.MouseLeave += new System.EventHandler(this.XemLichHoc_MouseLeave);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.Location = new System.Drawing.Point(0, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 44);
            this.button6.TabIndex = 18;
            this.button6.Text = "   Học phí   ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaoVien.FlatAppearance.BorderSize = 0;
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.btnGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Image")));
            this.btnGiaoVien.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 44);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(229, 44);
            this.btnGiaoVien.TabIndex = 15;
            this.btnGiaoVien.Text = "   Giáo viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            this.btnGiaoVien.MouseEnter += new System.EventHandler(this.btnGiaoVien_MouseEnter);
            this.btnGiaoVien.MouseLeave += new System.EventHandler(this.btnGiaoVien_MouseLeave);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 44);
            this.button5.TabIndex = 17;
            this.button5.Text = "   Lương    ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(81, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(226, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1372, 801);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(239, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(838, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "\"Điều ta biết như một giọt nước. Điều ta không biết thì mênh mông như cả đại dươn" +
    "g\"";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(254, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 61);
            this.label1.TabIndex = 10;
            this.label1.Text = "TRUNG TÂM HỌC THÊM LTPTL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormDNAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDNAM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pn_LichHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucTapCSDLDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.BindingSource thucTapCSDLDataSetBindingSource;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button btn_SaoLuu;
          private System.Windows.Forms.Button btnGiaoVien;
          private System.Windows.Forms.Button btnHocSinh;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.Button XemLichHoc;
          private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_LichHoc;
        private System.Windows.Forms.Button btn_ChemistryAD;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_EnglishAD;
        private System.Windows.Forms.Button btn_PhysicAD;
        private System.Windows.Forms.Button btn_MathAD;
        private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

