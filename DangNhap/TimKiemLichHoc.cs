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
    public partial class TimKiemLichHoc : UserControl
    {
        private Connection cn;
        private string maHS= HocSinh.TimMaHS();
        private static TimKiem_LichDay _instance;
        public TimKiemLichHoc()
        {
            cn = new Connection();
            InitializeComponent();
        }
        public string MaHS { get => maHS; set => maHS = value; }
        public static TimKiem_LichDay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TimKiem_LichDay(); ;
                }
                return _instance;
            }
        }

        private void TimKiemLichHoc_Load(object sender, EventArgs e)
        {
            dataGridViewTimKiemLichHoc.BorderStyle = BorderStyle.None;
            dataGridViewTimKiemLichHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            // DtViewAnh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTimKiemLichHoc.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewTimKiemLichHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Search_lichhoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHS", SqlDbType.Char, 10).Value = maHS;
                cmd.Parameters.Add("@day1", SqlDbType.Date).Value = dtpDay1.Value.Date;
                cmd.Parameters.Add("@day2", SqlDbType.Date).Value = dtpDay2.Value.Date;
                cmd.Connection = con;
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewTimKiemLichHoc.DataSource = dt.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
        }

        private void dataGridViewTimKiemLichHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTimKiemLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTimKiemLichHoc.Rows[e.RowIndex];
                textBoxSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                textBoxHoTen.Text = row.Cells["HoTenGV"].Value.ToString();
                textBox1MaLMH.Text = row.Cells["MALMH"].Value.ToString();
                textBoxKipHoc.Text = row.Cells["KipHoc"].Value.ToString();
                textBoxMaLichHoc.Text = row.Cells["MaLichHoc"].Value.ToString();
                dtpNgayHoc.Text = row.Cells["NgayHoc"].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
