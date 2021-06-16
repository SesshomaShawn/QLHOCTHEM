using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class TimKiem_LichDay_Ngay : UserControl
    {
        private Connection cn;
        private string maGV = GiaoVien.TimMaGV();
        private static TimKiem_LichDay_Ngay _instance;
        public TimKiem_LichDay_Ngay()
        {
            cn = new Connection();
            
            InitializeComponent();

        }
        public string MaGV { get => maGV; set => maGV = value; }
        public static TimKiem_LichDay_Ngay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TimKiem_LichDay_Ngay(); ;
                }
                return _instance;
            }
        }

        private void TimKiem_LichDay_Ngay_Load(object sender, EventArgs e)
        {
            dataGridView_Lich.BorderStyle = BorderStyle.None;
            dataGridView_Lich.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_Lich.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_Lich.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_Lich.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_Lich.BackgroundColor = Color.White;

            dataGridView_Lich.EnableHeadersVisualStyles = false;
            dataGridView_Lich.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_Lich.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_Lich.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Lich.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Search_lichday_theoNgay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaGV", SqlDbType.Char, 10).Value = maGV;
            cmd.Parameters.Add("@day", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView_Lich.DataSource = dt.Tables[0];
            con.Close();
        }

        private void dataGridView_Lich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Lich.Rows[e.RowIndex];
                textBoxSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                textBoxHoTen.Text = row.Cells["HoTenGV"].Value.ToString();
                textBoxMaLop.Text = row.Cells["MALMH"].Value.ToString();
                textBoxKip.Text = row.Cells["KipHoc"].Value.ToString();
            }
        }

        private void dataGridView_Lich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
