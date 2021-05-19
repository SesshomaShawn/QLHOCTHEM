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

        private void CbbTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "XemLichDay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaGV", SqlDbType.NChar, 10).Value = maGV;
            cmd.Parameters.Add("@TenMH", SqlDbType.NChar, 30).Value = cbbTenlop.SelectedItem;
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DtViewToan.DataSource = dt.Tables[0];
            LH_Toan.Text = DtViewToan.Rows[0].Cells["MaLichHoc"].Value.ToString();
            Tiet_Toan.Text = DtViewToan.Rows[0].Cells["SoTiet"].Value.ToString();
            GV_Toan.Text = DtViewToan.Rows[0].Cells["HoTenGV"].Value.ToString();
            ML_Toan.Text = DtViewToan.Rows[0].Cells["MaLMH"].Value.ToString();
            Ngay_Toan.Text = DtViewToan.Rows[0].Cells["NgayHoc"].Value.ToString();
            Kip_Toan.Text = DtViewToan.Rows[0].Cells["KipHoc"].Value.ToString();
        }

        private void DtViewToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtViewToan.Rows[e.RowIndex];
                LH_Toan.Text = row.Cells["MaLichHoc"].Value.ToString();
                Tiet_Toan.Text = row.Cells["SoTiet"].Value.ToString();
                GV_Toan.Text = row.Cells["HoTenGV"].Value.ToString();
                ML_Toan.Text = row.Cells["MaLMH"].Value.ToString();
                Ngay_Toan.Text = row.Cells["NgayHoc"].Value.ToString();
                Kip_Toan.Text = row.Cells["KipHoc"].Value.ToString();


            }
        }

        private void LichDay_Load(object sender, EventArgs e)
        {
            DtViewToan.BorderStyle = BorderStyle.None;
            DtViewToan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DtViewToan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DtViewToan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DtViewToan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DtViewToan.BackgroundColor = Color.White;

            DtViewToan.EnableHeadersVisualStyles = false;
            DtViewToan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DtViewToan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DtViewToan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
                cbbTenlop.Items.Add(row["TenLMH"].ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void GV_Toan_TextChanged(object sender, EventArgs e)
        {

        }

        private void ML_Toan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Ngay_Toan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kip_Toan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Tiet_Toan_TextChanged(object sender, EventArgs e)
        {

        }

        private void LH_Toan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtViewToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        
    
}
