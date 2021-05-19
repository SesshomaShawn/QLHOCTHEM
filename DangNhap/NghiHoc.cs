using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class NghiHoc : Form
    {       
        private Connection cn;      
        public string thang;
        public string nam;
        public string mail = "";
        private int sobuoinghi;
        public NghiHoc()
        {
            cn = new Connection();
            InitializeComponent();
        }

        private void NghiHoc_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                SqlCommand cmd = new SqlCommand();               
                cmd.CommandText = "NGHI_HOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@EMAIL", mail));
                cmd.Parameters.Add(new SqlParameter("@THANG", thang));
                cmd.Parameters.Add(new SqlParameter("@NAM", nam));
                cmd.Connection = con;
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtGBuoiNghi.DataSource = dt;
                con.Close();
                for (int i = 0; i < dtGBuoiNghi.Rows.Count - 1; i++)
                {
                    sobuoinghi += int.Parse(dtGBuoiNghi.Rows[i].Cells["sotietnghi"].Value.ToString());
                }
                txt_Tongtietnghi.Text = sobuoinghi.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
            dtGBuoiNghi.BorderStyle = BorderStyle.None;
            dtGBuoiNghi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dtGBuoiNghi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtGBuoiNghi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtGBuoiNghi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dtGBuoiNghi.BackgroundColor = Color.White;

            dtGBuoiNghi.EnableHeadersVisualStyles = false;
            //dtGBuoiNghi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dtGBuoiNghi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dtGBuoiNghi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
