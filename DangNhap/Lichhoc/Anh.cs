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
    public partial class Anh : UserControl
    {
        // duc toan
        private Connection cn;
        private static Anh _instance;
        public Anh()
        {
            cn = new Connection();
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TenLMH from LOPHOC where TenLMH like N'Tiếng%'";
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbAnh.Items.Add(reader["TenLMH"]);
            }
            reader.Close();
            con.Close();
        }
        public static Anh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Anh(); ;
                }
                return _instance;
            }
        }

        private void CbbAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Xem_LichHoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Ten", cbbAnh.SelectedItem));
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DtViewAnh.DataSource = dt.Tables[0];
            con.Close();
            MaLHTA.Text = DtViewAnh.Rows[0].Cells["MaLH"].Value.ToString();
            SotietTA.Text = DtViewAnh.Rows[0].Cells["Sotiet"].Value.ToString();
            GVTA.Text = DtViewAnh.Rows[0].Cells["HoTenGV"].Value.ToString();
            MaTA.Text = DtViewAnh.Rows[0].Cells["MaLMH"].Value.ToString();
            dtpAnh.Text = DtViewAnh.Rows[0].Cells["NgayHoc"].Value.ToString();
            KipHocTA.Text = DtViewAnh.Rows[0].Cells["KipHoc"].Value.ToString();
        }

        private void DtViewAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtViewAnh.Rows[e.RowIndex];
                MaLHTA.Text = row.Cells["MaLH"].Value.ToString();
                SotietTA.Text = row.Cells["Sotiet"].Value.ToString();
                GVTA.Text = row.Cells["HoTenGV"].Value.ToString();
                MaTA.Text = row.Cells["MaLMH"].Value.ToString();
                dtpAnh.Text = row.Cells["NgayHoc"].Value.ToString();
                KipHocTA.Text = row.Cells["KipHoc"].Value.ToString();
            }
        }

        private void Anh_Load(object sender, EventArgs e)
        {
            DtViewAnh.BorderStyle = BorderStyle.None;
            DtViewAnh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
           // DtViewAnh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DtViewAnh.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DtViewAnh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //DtViewAnh.BackgroundColor = Color.White;

           // DtViewAnh.EnableHeadersVisualStyles = false;
            //DtViewAnh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //DtViewAnh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //DtViewAnh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
