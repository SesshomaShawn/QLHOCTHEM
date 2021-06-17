using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class GiaoVien : Form
    {
        private static string tenDN = "";
        private static string maGV = "";
        private string pass = "";
        private static string hoTen = "";
        private string gioiTinh = "";
        private string diaChi = "";

        private Connection cn;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;


        public string Pass { get => pass; set => pass = value; }

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public static string MaGV { get => maGV; set => maGV = value; }
        public static string TenDN { get => tenDN; set => tenDN = value; }
        public static string HoTen { get => hoTen; set => hoTen = value; }


        public GiaoVien()
        {
            cn = new Connection();
            InitializeComponent();
            MacDinh();
            panel3.Controls.Add(home.Instance);
            home.Instance.Dock = DockStyle.Fill;
            home.Instance.BringToFront();
            //TimMaGV();
            //Toan1 toan1 = new Toan1();
            //toan1.MaGV = maGV;
        }
        public void MacDinh()
        {
            panel2.Visible = false;
        }
        public void AnLichDay()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
        }
        public void HienLichDay()
        {
            if (panel2.Visible == false)
            {
                AnLichDay();
                panel2.Visible = true;
            }
            else panel2.Visible = false;
        }
        

        private void btn_XemLuong_MouseEnter(object sender, EventArgs e)
        {
            btn_XemLuong.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_XemLuong_MouseLeave(object sender, EventArgs e)
        {
            btn_XemLuong.BackColor = System.Drawing.Color.White;
        }

        private void btn_XemLichDay_MouseEnter(object sender, EventArgs e)
        {
            btn_XemLichDay.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_XemLichDay_MouseLeave(object sender, EventArgs e)
        {
            btn_XemLichDay.BackColor = System.Drawing.Color.White;
        }


        private void btn_DoiMK_MouseEnter(object sender, EventArgs e)
        {
            btn_DoiMK.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_DoiMK_MouseLeave(object sender, EventArgs e)
        {
            btn_DoiMK.BackColor = System.Drawing.Color.White;
        }

        private void btn_TrangChu_MouseEnter(object sender, EventArgs e)
        {
            btn_TrangChu.BackColor = System.Drawing.Color.LightBlue;

        }

        private void btn_TrangChu_MouseLeave(object sender, EventArgs e)
        {
            btn_TrangChu.BackColor = System.Drawing.Color.White;
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

        private void btn_XemLuong_Click(object sender, EventArgs e)
        {
            //HienThiLuong();
            dataGridViewHienThiLuong.Visible = true;

            panel3.Controls.Clear();
            panel3.Controls.Add(dataGridViewHienThiLuong);
            panel6.Visible = true;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel3.Controls.Add(panel6);

            panel7.Visible = true;
            panel3.Visible = true;
        }

        public static string TimMaGV()
        {

            FormDN dangNhap = new FormDN();

            DataTable dataTable = dangNhap.Bang();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string ten = ((string)dataTable.Rows[i]["TenDN"]).Trim();
                if (TenDN == ((string)dataTable.Rows[i]["TenDN"]).Trim())
                {
                    MaGV = (string)dataTable.Rows[i]["Ma"];
                }
            }
            return MaGV;
        }

        public static string TimTenGV()
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



        private void btn_XemLichDay_Click(object sender, EventArgs e)
        {
            HienLichDay();
            /*if (!panel3.Controls.Contains(LichDay.Instance))
            {
                 panel3.Controls.Add(LichDay.Instance);
                 LichDay.Instance.Dock = DockStyle.Fill;
                 LichDay.Instance.BringToFront();
            }
            else
                 LichDay.Instance.BringToFront();
            */
        }



        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Ten = TenDN;
            dmk.pass = pass;
            if (!panel3.Controls.Contains(dmk))
            {
                panel3.Controls.Add(dmk);
                dmk.Dock = DockStyle.Fill;
                dmk.BringToFront();
            }
            else
                dmk.BringToFront();
        }


        int vt = -1;
        private void dataGridViewHienThiLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Tìm tên, giới tính, địa chỉ của GV
            FormDN dangNhap = new FormDN();
            DataTable dataTable = dangNhap.Bang();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string ten = ((string)dataTable.Rows[i]["TenDN"]).Trim();
                if (TenDN == ((string)dataTable.Rows[i]["TenDN"]).Trim())
                {
                    HoTen = (string)dataTable.Rows[i]["HoTen"];
                    gioiTinh = (string)dataTable.Rows[i]["GioiTinh"];
                    diaChi = (string)dataTable.Rows[i]["DiaChi"];
                }
            }
            vt = e.RowIndex;
            if (vt >= 0 && vt < dataSet.Tables["TableLuongGV"].Rows.Count)
            {
                DataRow row = dataSet.Tables["TableLuongGV"].Rows[vt];
                textBoxMaPL.Text = row["MaPL"] + "";
                DateTime dt = (DateTime)row["NgayTra"];
                textBoxNgayTra.Text = dt.ToString("dd/MM/yyyy");
                textBoxTongTien.Text = row["TongTien"] + "";
                textBoxHoTenGV.Text = HoTen;
                textBoxGT.Text = gioiTinh;
                textBoxDiaChi.Text = diaChi;
            }
            else
            {
                textBoxMaPL.Text = "";
                textBoxNgayTra.Text = "";
                textBoxTongTien.Text = "";
                textBoxHoTenGV.Text = HoTen;
                textBoxGT.Text = gioiTinh;
                textBoxDiaChi.Text = diaChi;
            }
        }



        private void HienThiLuong()
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XemLuong";
            cmd.Parameters.Add("@MaGV", SqlDbType.NChar, 10).Value = TimMaGV();
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = comboBoxChonThang.SelectedItem;
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = combonămChonNam.SelectedItem;

            cmd.Connection = con;

            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataSet = new DataSet();

            adapter.Fill(dataSet, "TableLuongGV");

            dataGridViewHienThiLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHienThiLuong.DataSource = dataSet.Tables["TableLuongGV"];

            con.Close();

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combonămChonNam.SelectedItem != null)
            {
                HienThiLuong();
            }
        }

        private void combonămChonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChonThang.SelectedItem != null)
            {
                HienThiLuong();
            }
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {

            label10.Text = "Xin chào " + TimTenGV() + "!";
            dataGridViewHienThiLuong.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewHienThiLuong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewHienThiLuong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHienThiLuong.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewHienThiLuong.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewHienThiLuong.BackgroundColor = Color.White;

            dataGridViewHienThiLuong.EnableHeadersVisualStyles = false;
            dataGridViewHienThiLuong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHienThiLuong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewHienThiLuong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDN dn = new FormDN();
            dn.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_LichHoc_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void buttonXem_theoLop_MouseLeave(object sender, EventArgs e)
        {
            buttonXem_theoLop.BackColor = System.Drawing.Color.White;
        }

        private void buttonXem_theoLop_MouseEnter(object sender, EventArgs e)
        {
            buttonXem_theoLop.BackColor = System.Drawing.Color.LightBlue;
        }

        private void buttonXem_TheoNgay_MouseLeave(object sender, EventArgs e)
        {
            buttonXem_TheoNgay.BackColor = System.Drawing.Color.White;
        }

        private void buttonXem_TheoNgay_MouseEnter(object sender, EventArgs e)
        {
            buttonXem_TheoNgay.BackColor = System.Drawing.Color.LightBlue;
        }

        private void buttonXem_theotg_MouseLeave(object sender, EventArgs e)
        {
            buttonXem_theotg.BackColor = System.Drawing.Color.White;
        }

        private void buttonXem_theotg_MouseEnter(object sender, EventArgs e)
        {
            buttonXem_theotg.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_XemLichDay_MouseClick(object sender, MouseEventArgs e)
        {

        }
        
        private void buttonXem_theoLop_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(LichDay.Instance))
            {
                panel3.Controls.Add(LichDay.Instance);
                LichDay.Instance.Dock = DockStyle.Fill;
                LichDay.Instance.BringToFront();
            }
            else
                LichDay.Instance.BringToFront();
        }

        private void buttonXem_TheoNgay_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(TimKiem_LichDay_Ngay.Instance))
            {
                panel3.Controls.Add(TimKiem_LichDay_Ngay.Instance);
                TimKiem_LichDay_Ngay.Instance.Dock = DockStyle.Fill;
                TimKiem_LichDay_Ngay.Instance.BringToFront();
            }
            else
                TimKiem_LichDay_Ngay.Instance.BringToFront();
        }

        private void buttonXem_theotg_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(TimKiem_LichDay.Instance))
            {
                panel3.Controls.Add(TimKiem_LichDay.Instance);
                TimKiem_LichDay.Instance.Dock = DockStyle.Fill;
                TimKiem_LichDay.Instance.BringToFront();
            }
            else
                TimKiem_LichDay.Instance.BringToFront();
        }

        private void btn_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = System.Drawing.Color.White;
        }
    }

}
