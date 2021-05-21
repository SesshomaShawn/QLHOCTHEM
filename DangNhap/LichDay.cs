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
    public partial class LichDay : UserControl
    {
        private Connection cn;
        private string maGV = GiaoVien.TimMaGV();
        private static LichDay _instance;
        DataSet dt = null;
        public LichDay()
        {
            cn = new Connection();
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XemLopDayCuaGV";
            cmd.Parameters.Add("@MaGV", SqlDbType.NChar, 10).Value = maGV;
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //cbbTenlop.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
        }


        public static LichDay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LichDay(); ;
                }
                return _instance;
            }
        }

        public string MaGV { get => maGV; set => maGV = value; }


        private void LichDay_Load(object sender, EventArgs e)
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
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cbb";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaGV", SqlDbType.NChar, 10).Value = maGV;
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

          
            
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                //MessageBox.Show(row["TegnLMH"].ToString());
                cbbTenLop.Items.Add(row["TenLMH"].ToString());
            }
        }

       
        
        private void cbbTenLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "XemLichDay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaGV", SqlDbType.NChar, 10).Value = maGV;
            cmd.Parameters.Add("@TenMH", SqlDbType.NChar, 30).Value = cbbTenLop.SelectedItem;
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView_Lich.DataSource = dt.Tables[0];
            con.Close();
        }

        private void dataGridView_Lich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            try
            {
                DataGridViewRow row = this.dataGridView_Lich.Rows[e.RowIndex];
                textBoxSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                textBoxHoTen.Text = row.Cells["HoTenGV"].Value.ToString();
                DateTime date = (DateTime) row.Cells["NgayHoc"].Value;
                textBoxNgayHoc.Text = date.ToString("dd/MM/yyyy");
                textBoxKip.Text = row.Cells["KipHoc"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
           
        }
    }

        
    
}
