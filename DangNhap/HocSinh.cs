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
        private static string hoTen = "";
        private static string maHS = "";
        public static string Tendangnhap = "";
        public string password = "";
        public static string MaHS { get => maHS; set => maHS = value; }
        public static string TenDN { get => Tendangnhap; set => Tendangnhap = value; }
        public static string HoTen { get => hoTen; set => hoTen = value; }
        public HocSinh()
        {
            cn = new Connection();
            InitializeComponent();
            MacDinh();
            panel3.Controls.Add(home.Instance);
            home.Instance.Dock = DockStyle.Fill;
            home.Instance.BringToFront();
        }
        public static string TimMaHS()
        {

            FormDN dangNhap = new FormDN();

            DataTable dataTable = dangNhap.Bang();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string ten = ((string)dataTable.Rows[i]["TenDN"]).Trim();
                if (TenDN == ((string)dataTable.Rows[i]["TenDN"]).Trim())
                {
                    MaHS = (string)dataTable.Rows[i]["Ma"];
                }
            }
            return MaHS;
        }
        private static string layten()
        {
            FormDN dangNhap = new FormDN();

            DataTable dataTable = dangNhap.Bang();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string ten = ((string)dataTable.Rows[i]["TenDN"]).Trim();
                if (TenDN == ((string)dataTable.Rows[i]["TenDN"]).Trim())
                {
                    HoTen = (string)dataTable.Rows[i]["HoTen"];
                }
            }
            string first_name = HoTen.Substring(HoTen.LastIndexOf(' ') + 1);
            return first_name;
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
            hp.email = Tendangnhap;
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
            if (!panel3.Controls.Contains(Lop_DaDangKy.Instance))
            {
                panel3.Controls.Add(Lop_DaDangKy.Instance);
                Lop_DaDangKy.Instance.Dock = DockStyle.Fill;
                Lop_DaDangKy.Instance.BringToFront();
            }
            else
                Lop_DaDangKy.Instance.BringToFront();
        }

        private void btn_Li_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Lop_ChuaDangKy.Instance))
            {
                panel3.Controls.Add(Lop_ChuaDangKy.Instance);
                Lop_ChuaDangKy.Instance.Dock = DockStyle.Fill;
                Lop_ChuaDangKy.Instance.BringToFront();
            }
            else
                Lop_ChuaDangKy.Instance.BringToFront();

        }

        private void btn_Hoa_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(TimKiemLichHoc_Ngay.Instance))
            {
                panel3.Controls.Add(TimKiemLichHoc_Ngay.Instance);
                TimKiemLichHoc_Ngay.Instance.Dock = DockStyle.Fill;
                TimKiemLichHoc_Ngay.Instance.BringToFront();
            }
            else
                TimKiemLichHoc_Ngay.Instance.BringToFront();
        }

        private void tbn_Van_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(TimKiemLichHoc.Instance))
            {
                panel3.Controls.Add(TimKiemLichHoc.Instance);
                TimKiemLichHoc.Instance.Dock = DockStyle.Fill;
                TimKiemLichHoc.Instance.BringToFront();
            }
            else
                TimKiemLichHoc.Instance.BringToFront();
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
            dmk.Ten = Tendangnhap;
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
