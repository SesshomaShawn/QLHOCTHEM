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
    public partial class TimKiem_LichDay : UserControl
    {
        private Connection cn;
        private string maGV = GiaoVien.TimMaGV();
        private static TimKiem_LichDay _instance;
        public TimKiem_LichDay()
        {
            cn = new Connection();
            InitializeComponent();
        }
        public string MaGV { get => maGV; set => maGV = value; }
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

        private void TimKiem_LichDay_Load(object sender, EventArgs e)
        {
            dataGridView_Lich.BorderStyle = BorderStyle.FixedSingle;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Search_lichday";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaGV", SqlDbType.Char, 10).Value = maGV;
                cmd.Parameters.Add("@day1", SqlDbType.Date).Value = dtpDay1.Value.Date;
                cmd.Parameters.Add("@day2", SqlDbType.Date).Value = dtpDay2.Value.Date;
                cmd.Connection = con;
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView_Lich.DataSource = dt.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
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
    }
}
