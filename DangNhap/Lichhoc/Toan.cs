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
    public partial class Lichhoc : UserControl
    {
        private Connection cn;
        private static Lichhoc _instance;
        public Lichhoc()
        {
            //hey
            cn = new Connection();
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TenLMH from LOPHOC where TenLMH like 'Toán%'";
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbTenlop.Items.Add(reader["TenLMH"]);
            }
            reader.Close();
            con.Close();
        }     
        public static Lichhoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lichhoc(); ;
                }
                return _instance;
            }
        }

        private void CbbTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Xem_LichHoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Ten", cbbTenlop.SelectedItem));
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DtViewToan.DataSource = dt.Tables[0];
            con.Close();
            LH_Toan.Text = DtViewToan.Rows[0].Cells["MaLH_Toan"].Value.ToString();
            Tiet_Toan.Text = DtViewToan.Rows[0].Cells["SoTiet_Toan"].Value.ToString();
            GV_Toan.Text = DtViewToan.Rows[0].Cells["HoTenGV_Toan"].Value.ToString();
            ML_Toan.Text = DtViewToan.Rows[0].Cells["MaLMH_Toan"].Value.ToString();
            dtpToan.Text = DtViewToan.Rows[0].Cells["NgayHoc_Toan"].Value.ToString();
            Kip_Toan.Text = DtViewToan.Rows[0].Cells["KipHoc_Toan"].Value.ToString();
        }

        private void DtViewToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtViewToan.Rows[e.RowIndex];
                LH_Toan.Text = row.Cells["MaLH_Toan"].Value.ToString();
                Tiet_Toan.Text = row.Cells["SoTiet_Toan"].Value.ToString();
                GV_Toan.Text = row.Cells["HoTenGV_Toan"].Value.ToString();
                ML_Toan.Text = row.Cells["MaLMH_Toan"].Value.ToString();
                dtpToan.Text = row.Cells["NgayHoc_Toan"].Value.ToString();
                Kip_Toan.Text = row.Cells["KipHoc_Toan"].Value.ToString();


            }
        }

        private void Lichhoc_Load(object sender, EventArgs e)
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
        }
    }

        
    
}
