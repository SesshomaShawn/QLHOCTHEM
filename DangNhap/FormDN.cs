using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DangNhap
{
     public partial class FormDN : Form
     {
            private Connection cn;
            private DataTable myTable;
            public FormDN()
            {
                cn = new Connection();
                InitializeComponent();
                myTable = Bang();
            }

            void button1_Click(object sender, EventArgs e)
            {
                DangNhap();
            }
     
          private void DangNhap()
          {
               string Quyen = null;
               int cout = myTable.Rows.Count;
               string t1 = TextUser.Text;
               string t2 = TextPass.Text;
               if (TextUser.Text == "")
               {
                    MessageBox.Show("Bạn chưa nhập tài khoản");
                    TextUser.Focus();
               }
               else if (t2 == "")
               {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    TextPass.Focus();
               }
               else
               {
                    for (int i = 0; i < cout; i++)
                    {
                         string s1 = myTable.Rows[i]["TenDN"].ToString();

                         string s2 = myTable.Rows[i]["MatKhau"].ToString();
                         if (t1.Trim() == s1.Trim() && t2.Trim() == s2.Trim())
                         {
                              Quyen = myTable.Rows[i]["PhanQuyen"].ToString();
                              break;
                         }
                         if (i == cout - 1)
                         {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                            this.TextUser.Focus();
                            this.TextUser.SelectAll();
                            break; }

                    }
               }
               if (Quyen == "HocSinh")
               {

                    
                    HocSinh hs = new HocSinh();
                    HocSinh.Tendangnhap = this.TextUser.Text;
                    hs.password = this.TextPass.Text;
                    hs.ShowDialog();
                    this.Close();

               }

               if (Quyen == "GiaoVien") // dang nhap theo giao vien
               {
                    GiaoVien gv = new GiaoVien();
                    GiaoVien.TenDN = TextUser.Text.Trim();
                    gv.Pass = TextPass.Text.Trim();
                    gv.ShowDialog(); 

                    this.Close();

               }
               if (Quyen == "admin")
               {
                    FormDNAM f1 = new FormDNAM();
                    f1.ShowDialog();
                    this.Close();
               }

          }
          public DataTable Bang()
          { 
               SqlConnection con = new SqlConnection();
               con = cn.GetConnection();
               SqlDataAdapter HS = new SqlDataAdapter("SELECT * FROM dbo.HOCSINH ", con);
               SqlDataAdapter GV = new SqlDataAdapter("SELECT * FROM dbo.GIAOVIEN", con);
               DataTable hs = new DataTable(), gv = new DataTable();
               GV.Fill(gv); HS.Fill(hs);
               int coutHS = hs.Rows.Count, coutGV = gv.Rows.Count;
               DataTable dt = new DataTable();

               dt.Columns.Add("Ma");
               dt.Columns.Add("TenDN");
               dt.Columns.Add("MatKhau");
               dt.Columns.Add("PhanQuyen");
               dt.Columns.Add("HoTen");
               dt.Columns.Add("GioiTinh");
               dt.Columns.Add("DiaChi");

               DataRow adminDN = dt.NewRow();
               adminDN["TenDN"] = adminDN["MatKhau"] = adminDN["PhanQuyen"] = "admin";
               dt.Rows.Add(adminDN);

               for (int i = 0; i < coutHS; i++)
               {
                    DataRow row = dt.NewRow();
                    row["Ma"] = hs.Rows[i]["MaHS"];
                    row["TenDN"] = hs.Rows[i]["Email"].ToString();
                    row["MatKhau"] = hs.Rows[i]["MatKhau"].ToString(); ;
                    row["PhanQuyen"] = "HocSinh";
                    row["HoTen"] = hs.Rows[i]["HoTenHS"].ToString();
                    row["GioiTinh"] = hs.Rows[i]["GioiTinh"].ToString();
                    row["DiaChi"] = hs.Rows[i]["DiaChi"].ToString();
                    dt.Rows.Add(row);
               }
               for (int i = 0; i < coutGV; i++)
               {
                    DataRow row = dt.NewRow();
                    row["Ma"] = gv.Rows[i]["MaGV"];
                    row["TenDN"] = gv.Rows[i]["Email"].ToString();
                    row["MatKhau"] = gv.Rows[i]["MatKhau"].ToString();
                    row["PhanQuyen"] = "GiaoVien";
                    row["HoTen"] = gv.Rows[i]["HoTenGV"].ToString();
                    row["GioiTinh"] = gv.Rows[i]["GioiTinh"].ToString();
                    row["DiaChi"] = gv.Rows[i]["DiaChi"].ToString();
                    dt.Rows.Add(row);
               }

               return dt;
          }

        private void TextPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DangNhap();
            if (e.KeyCode == Keys.Space)
                chuyenTrangThai();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            chuyenTrangThai();
        }

        private void chuyenTrangThai()
        {
            TextPass.UseSystemPasswordChar = !TextPass.UseSystemPasswordChar;
            if (TextPass.UseSystemPasswordChar == false)
            {
                this.button2.BackgroundImage = global::DangNhap.Properties.Resources.mắt_new_removebg_preview33;
            }
            else
            {
                this.button2.BackgroundImage = global::DangNhap.Properties.Resources.măt_new_mã_33;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          /*  this.TextUser.Text = "Tên đăng nhập";
            this.TextUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextPass.Text = "Mật khẩu";
            this.TextPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextPass.UseSystemPasswordChar = false;*/

        }

        private void TextUser_Click(object sender, EventArgs e)
        {
           /* if (TextUser.Text.Trim() == "Tên đăng nhập")
            {
                this.TextUser.Clear();
                this.TextPass.Clear();
                this.TextUser.ForeColor = System.Drawing.SystemColors.WindowText;
                this.TextPass.ForeColor = System.Drawing.SystemColors.WindowText;
                this.TextPass.UseSystemPasswordChar = true;
            }
*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextPass.UseSystemPasswordChar = !TextPass.UseSystemPasswordChar;
            if (TextPass.UseSystemPasswordChar == false)
            {
                this.button2.BackgroundImage = global::DangNhap.Properties.Resources.mắt_new_removebg_preview33;
            }
            else
            {
                this.button2.BackgroundImage = global::DangNhap.Properties.Resources.măt_new_mã_33;
            }
        }
    }
}
