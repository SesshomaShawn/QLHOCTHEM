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
    public partial class TimKiemLichHoc_Ngay : UserControl
    {
        private Connection cn;
        private string maHS = HocSinh.TimMaHS();
        private static TimKiemLichHoc_Ngay _instance;
        public TimKiemLichHoc_Ngay()
        {
            cn = new Connection();
            InitializeComponent();
        }
        public string MaHS { get => maHS; set => maHS = value; }
        public static TimKiemLichHoc_Ngay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TimKiemLichHoc_Ngay(); ;
                }
                return _instance;
            }
        }

        private void dtpDay1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Search_lichhoc_theoNgay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHS", SqlDbType.Char, 10).Value = maHS;
                cmd.Parameters.Add("@day", SqlDbType.Date).Value = dtpDay1.Value.Date;
                cmd.Connection = con;
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewTimKiemLichHoc_Ngay.DataSource = dt.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
        }


        private void TimKiemLichHoc_Ngay_Load(object sender, EventArgs e)
        {
            dataGridViewTimKiemLichHoc_Ngay.BorderStyle = BorderStyle.None;
            dataGridViewTimKiemLichHoc_Ngay.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            // DtViewAnh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTimKiemLichHoc_Ngay.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewTimKiemLichHoc_Ngay.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }

        private void dataGridViewTimKiemLichHoc_Ngay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTimKiemLichHoc_Ngay.Rows[e.RowIndex];
                textBoxSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                textBoxHoTen.Text = row.Cells["HoTenGV"].Value.ToString();
                textBox1MaLMH.Text = row.Cells["TenLMH"].Value.ToString();
                textBoxKipHoc.Text = row.Cells["KipHoc"].Value.ToString();
                textBoxMaLichHoc.Text = row.Cells["MaLichHoc"].Value.ToString();
                textBoxNgayHoc.Text = row.Cells["NgayHoc"].Value.ToString();
            }
        }
    }
}


