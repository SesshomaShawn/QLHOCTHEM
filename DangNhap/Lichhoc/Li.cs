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
    public partial class Li : UserControl
    {
        private Connection cn;
        private static Li _instance;
        public Li()
        {
            cn = new Connection();
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TenLMH from LOPHOC where TenLMH like N'Lý%'";
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbLi.Items.Add(reader["TenLMH"]);
            }
            reader.Close();
            con.Close();
        }
        public static Li Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Li(); ;
                }
                return _instance;
            }
        }

        private void CbbLi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Xem_LichHoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Ten", cbbLi.SelectedItem));
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtViewli.DataSource = dt.Tables[0];
            con.Close();
            LH_Li.Text = dtViewli.Rows[0].Cells["MaLH_Li"].Value.ToString();
            Tiet_Li.Text = dtViewli.Rows[0].Cells["SoTiet_Li"].Value.ToString();
            GV_Li.Text = dtViewli.Rows[0].Cells["HoTenGV_Li"].Value.ToString();
            ML_Li.Text = dtViewli.Rows[0].Cells["MaLMH_Li"].Value.ToString();
            dtpLi.Text = dtViewli.Rows[0].Cells["NgayHoc_Li"].Value.ToString();
            Kip_Li.Text = dtViewli.Rows[0].Cells["KipHoc_Li"].Value.ToString();
        }

        private void DtViewli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtViewli.Rows[e.RowIndex];
                LH_Li.Text = row.Cells["MaLH_Li"].Value.ToString();
                Tiet_Li.Text = row.Cells["SoTiet_Li"].Value.ToString();
                GV_Li.Text = row.Cells["HoTenGV_Li"].Value.ToString();
                ML_Li.Text = row.Cells["MaLMH_Li"].Value.ToString();
                dtpLi.Text = row.Cells["NgayHoc_Li"].Value.ToString();
                Kip_Li.Text = row.Cells["KipHoc_Li"].Value.ToString();


            }
        }

        private void Li_Load(object sender, EventArgs e)
        {
            dtViewli.BorderStyle = BorderStyle.None;
            dtViewli.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtViewli.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtViewli.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtViewli.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtViewli.BackgroundColor = Color.White;

            dtViewli.EnableHeadersVisualStyles = false;
            dtViewli.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtViewli.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtViewli.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
