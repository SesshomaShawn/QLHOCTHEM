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
               string t2 = textPass_see.Text;
               if (TextUser.Text == "")
               {
                    MessageBox.Show("Bạn chưa nhập tài khoản");
                    TextUser.Focus();
               }
               else if (t2 == "")
               {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    textPass_see.Focus();
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
                    hs.Tendangnhap = this.TextUser.Text;
                    hs.password = this.textPass_see.Text;
                    hs.ShowDialog();
                    this.Close();

               }

               if (Quyen == "GiaoVien") // dang nhap theo giao vien
               {
                    GiaoVien gv = new GiaoVien();
                    GiaoVien.TenDN = TextUser.Text.Trim();
                    gv.Pass = textPass_see.Text.Trim();
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textPass_see.Hide();
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            textPass_see.Show();
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextPass.Text = textPass_see.Text;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

      
    }
}
