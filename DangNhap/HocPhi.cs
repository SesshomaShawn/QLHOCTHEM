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
{//
    public partial class HocPhi : UserControl
    {
        //
        private Connection cn;
        public string email = "";
        public HocPhi()
        {
            cn = new Connection();
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbbthang.Items.Add(i);
            }

        }

        private void dataGRidView_Paint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataviewHP.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataviewHP.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        private void Btn_xem_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "XEM_HOCPHI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ten", email));
                cmd.Parameters.Add(new SqlParameter("@NAM", cbbnam.SelectedItem.ToString()));
                cmd.Parameters.Add(new SqlParameter("@THANG", cbbthang.SelectedItem.ToString()));
                cmd.Connection = con;
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataviewHP.DataSource = dt;
                con.Close();
                TBtenLMH.Text = dataviewHP.Rows[0].Cells["monhoc"].Value.ToString();
                TB_Sotien.Text = dataviewHP.Rows[0].Cells["Sotientiet"].Value.ToString();
                TB_Sotiet.Text = dataviewHP.Rows[0].Cells["Sotietdihoc"].Value.ToString();
                txtTinhTrang.Text = dataviewHP.Rows[0].Cells["TinhTrangDong"].Value.ToString();


            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }

        }

        private void DataviewHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataviewHP.Rows[e.RowIndex];
                TBtenLMH.Text = row.Cells["monhoc"].Value.ToString();
                TB_Sotien.Text = row.Cells["Sotientiet"].Value.ToString();
                TB_Sotiet.Text = row.Cells["Sotietdihoc"].Value.ToString();
                txtTinhTrang.Text = row.Cells["TinhTrangDong"].Value.ToString();
            }
        }

        private void Cbbthang_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2030; i++)
            {
                cbbnam.Items.Add(i);
            }
        }

        private void HocPhi_Load(object sender, EventArgs e)
        {
            /*
          dataviewHP.BorderStyle = BorderStyle.None;
          dataviewHP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
          //dataviewHP.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
          dataviewHP.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
          dataviewHP.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
          //dataviewHP.BackgroundColor = Color.White;

          dataviewHP.EnableHeadersVisualStyles = false;
            //dataviewHP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataviewHP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataviewHP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            */
            dataviewHP.BorderStyle = BorderStyle.FixedSingle;
            dataviewHP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataviewHP.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataviewHP.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataviewHP.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataviewHP.BackgroundColor = Color.White;

            dataviewHP.EnableHeadersVisualStyles = false;
            dataviewHP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataviewHP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataviewHP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Btn_BuoiNghi_Click(object sender, EventArgs e)
        {
            if (cbbthang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                return;
            }
            try
            {
                NghiHoc NH = new NghiHoc();
                NH.thang = cbbthang.SelectedItem.ToString();
                NH.nam = cbbnam.SelectedItem.ToString();
                NH.mail = this.email;
                NH.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Cần xem chi tiết học phí trước!");
            }
        }

        private void dataviewHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TB_Sotien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
