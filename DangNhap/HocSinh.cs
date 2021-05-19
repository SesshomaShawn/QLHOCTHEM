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
    public partial class HocSinh : Form
    {
        private Connection cn;
        string ten = "";       
        public string Tendangnhap = "";
        public string password = "";
        public HocSinh()
        {
            cn = new Connection();
            InitializeComponent();
            MacDinh();
            panel3.Controls.Add(home.Instance);
            home.Instance.Dock = DockStyle.Fill;
            home.Instance.BringToFront();
        }
        private string layten()
        {         
            try
            {
                SqlConnection con = cn.GetConnection();
                con.Open();
                string tk = this.Tendangnhap;              
                string sql = "Select HoTenHS from HOCSINH where Email = '" + tk + " '";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    ten = dt.GetValue(dt.GetOrdinal("HoTenHS")).ToString();
                    string[] arrayStr = ten.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);                 
                    ten = arrayStr[arrayStr.Length - 1];
                }
            }
            catch 
            {

            }
            return ten;
        }
        public void MacDinh()
        {
            panel_LichHoc.Visible = false;
        }
        public void AnLichHoc()
        {
            if (panel_LichHoc.Visible == true)
                panel_LichHoc.Visible = false;
        }
        public void HienLichHoc()
        {
            if (panel_LichHoc.Visible == false)
            {
                AnLichHoc();
                panel_LichHoc.Visible = true;
            }
            else panel_LichHoc.Visible = false;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //btn_TrangChu.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
        }

        private void btn_TrangChu_MouseLeave(object sender, EventArgs e)
        {
            //btn_TrangChu.BackColor = System.Drawing.Color.Purple;
        }

        private void btn_Xemlichhoc_MouseEnter(object sender, EventArgs e)
        {
            //btn_Xemlichhoc.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
        }

        private void btn_Xemlichhoc_MouseLeave(object sender, EventArgs e)
        {
            //btn_Xemlichhoc.BackColor = System.Drawing.Color.Purple;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            //btn_hocphi.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
           // btn_hocphi.BackColor = System.Drawing.Color.Purple;
        }


        private void btn_DoiMK_MouseEnter(object sender, EventArgs e)
        {
            //btn_DoiMK.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
        }

        private void btn_DoiMK_MouseLeave(object sender, EventArgs e)
        {
            //btn_DoiMK.BackColor = System.Drawing.Color.Purple;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(home.Instance))
            {
                    panel3.Controls.Add(home.Instance);
                    home.Instance.Dock = DockStyle.Fill;
                    home.Instance.BringToFront();
            }
            else
            home.Instance.BringToFront();
            
        }

        private void btn_hocphi_Click(object sender, EventArgs e)
        {

            AnLichHoc();
            HocPhi hp = new HocPhi();
            hp.email = this.Tendangnhap;
            if (!panel3.Controls.Contains(hp))
            {
                panel3.Controls.Add(hp);
                hp.Dock = DockStyle.Fill;
                hp.BringToFront();
            }
            else
                hp.BringToFront();
        }

        private void btn_Xemlichhoc_Click(object sender, EventArgs e)
        {
            HienLichHoc();
        }

        private void btn_Toan_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Lichhoc.Instance))
            {
                panel3.Controls.Add(Lichhoc.Instance);
                Lichhoc.Instance.Dock = DockStyle.Fill;
                Lichhoc.Instance.BringToFront();
            }
            else
                Lichhoc.Instance.BringToFront();
        }

        private void btn_Li_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Li.Instance))
            {
                panel3.Controls.Add(Li.Instance);
                Li.Instance.Dock = DockStyle.Fill;
                Li.Instance.BringToFront();
            }
            else
                Li.Instance.BringToFront();

        }

        private void btn_Hoa_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Hoa.Instance))
            {
                panel3.Controls.Add(Hoa.Instance);
                Hoa.Instance.Dock = DockStyle.Fill;
                Hoa.Instance.BringToFront();
            }
            else
                Hoa.Instance.BringToFront();
        }

        private void tbn_Van_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Van.Instance))
            {
                panel3.Controls.Add(Van.Instance);
                Van.Instance.Dock = DockStyle.Fill;
                Van.Instance.BringToFront();
            }
            else
                Van.Instance.BringToFront();
        }


        private void btn_Anh_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Anh.Instance))
            {
                panel3.Controls.Add(Anh.Instance);
                Anh.Instance.Dock = DockStyle.Fill;
                Anh.Instance.BringToFront();
            }
            else
                Anh.Instance.BringToFront();
        }

        private void Btn_DoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Ten = this.Tendangnhap;
            dmk.pass = this.password;
            if (!panel3.Controls.Contains(dmk))
            {
                panel3.Controls.Add(dmk);
                dmk.Dock = DockStyle.Fill;
                dmk.BringToFront();
            }
            else
                dmk.BringToFront();
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            FormDN dn = new FormDN();
            dn.ShowDialog();
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Xin chào " + layten() + " !";
        }
    }
}
