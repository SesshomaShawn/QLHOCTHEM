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
    public partial class Van : UserControl
    {
        private Connection cn;
        private static Van _instance;
        public Van()
        {
            /*long long*/
            cn = new Connection();
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TenLMH from LOPHOC where TenLMH like N'Văn%'";
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbVan.Items.Add(reader["TenLMH"]);
            }
            reader.Close();
            con.Close();
        }
        public static Van Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Van(); ;
                }
                return _instance;
            }
        }

        private void CbbVan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Xem_LichHoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Ten", cbbVan.SelectedItem));
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtViewVan.DataSource = dt.Tables[0];
            con.Close();
            LH_Van.Text = dtViewVan.Rows[0].Cells["MaLH_Van"].Value.ToString();
            Tiet_Van.Text = dtViewVan.Rows[0].Cells["SoTiet_Van"].Value.ToString();
            GV_Van.Text = dtViewVan.Rows[0].Cells["HoTenGV_Van"].Value.ToString();
            ML_Van.Text = dtViewVan.Rows[0].Cells["MaLMH_Van"].Value.ToString();
            dtpVan.Text = dtViewVan.Rows[0].Cells["NgayHoc_Van"].Value.ToString();
            Kip_Van.Text = dtViewVan.Rows[0].Cells["KipHoc_Van"].Value.ToString();
        }

        private void DtViewVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtViewVan.Rows[e.RowIndex];
                LH_Van.Text = row.Cells["MaLH_Van"].Value.ToString();
                Tiet_Van.Text = row.Cells["SoTiet_Van"].Value.ToString();
                GV_Van.Text = row.Cells["HoTenGV_Van"].Value.ToString();
                ML_Van.Text = row.Cells["MaLMH_Van"].Value.ToString();
                dtpVan.Text = row.Cells["NgayHoc_Van"].Value.ToString();
                Kip_Van.Text = row.Cells["KipHoc_Van"].Value.ToString();


            }
        }

        private void Van_Load(object sender, EventArgs e)
        {
                  dtViewVan.BorderStyle = BorderStyle.None;
                  dtViewVan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                  //dtViewVan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                  dtViewVan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                  dtViewVan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                  //dtViewVan.BackgroundColor = Color.White;

                  //dtViewVan.EnableHeadersVisualStyles = false;
                  //dtViewVan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                  //dtViewVan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                  //dtViewVan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
