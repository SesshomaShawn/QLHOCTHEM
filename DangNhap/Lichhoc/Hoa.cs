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
    public partial class Hoa : UserControl
    {
        //tuandeptrai
        private Connection cn;
        private static Hoa _instance;
        public Hoa()
        {
            cn = new Connection();
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TenLMH from LOPHOC where TenLMH like N'Hóa%'";
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbHoa.Items.Add(reader["TenLMH"]);
            }
            reader.Close();
            con.Close();
        }
        public static Hoa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hoa(); ;
                }
                return _instance;
            }
        }

        private void CbbHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Xem_LichHoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Ten", cbbHoa.SelectedItem));
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtViewhoa.DataSource = dt.Tables[0];
            con.Close();
            MaLHHH.Text = dtViewhoa.Rows[0].Cells["MaLH_Hoa"].Value.ToString();
            sotietHH.Text = dtViewhoa.Rows[0].Cells["SoTiet_Hoa"].Value.ToString();
            GVHH.Text = dtViewhoa.Rows[0].Cells["HoTenGV_Hoa"].Value.ToString();
            MaLHH.Text = dtViewhoa.Rows[0].Cells["MaLMH_Hoa"].Value.ToString();
            dtpHoa.Text = dtViewhoa.Rows[0].Cells["NgayHoc_Hoa"].Value.ToString();
            KipHocHH.Text = dtViewhoa.Rows[0].Cells["KipHoc_Hoa"].Value.ToString();
        }

        private void DtViewhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtViewhoa.Rows[e.RowIndex];
                MaLHHH.Text = row.Cells["MaLH_Hoa"].Value.ToString();
                sotietHH.Text = row.Cells["Sotiet_Hoa"].Value.ToString();
                GVHH.Text = row.Cells["HoTenGV_Hoa"].Value.ToString();
                MaLHH.Text = row.Cells["MaLMH_Hoa"].Value.ToString();
                dtpHoa.Text = row.Cells["NgayHoc_Hoa"].Value.ToString();
                KipHocHH.Text = row.Cells["KipHoc_Hoa"].Value.ToString();


            }
        }

        private void Hoa_Load(object sender, EventArgs e)
        {
            dtViewhoa.BorderStyle = BorderStyle.None;
            dtViewhoa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dtViewhoa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtViewhoa.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtViewhoa.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dtViewhoa.BackgroundColor = Color.White;

            dtViewhoa.EnableHeadersVisualStyles = false;
            //dtViewhoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dtViewhoa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
           //dtViewhoa.ColumnHeadersDefault*///CellStyle.ForeColor = Color.White;
        }
    }
}
