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
    public partial class ThemHS : Form
    {
        private Connection cn;
        SqlCommand cmd = new SqlCommand();

        private static ThemHS _instance;
        public static ThemHS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThemHS(); ;
                }
                return _instance;
            }
        }
        public ThemHS()
        {
            cn = new Connection();
            InitializeComponent();
            textBoxMaHS.Text = SinhMa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHocSinh();
        }

        private void ThemHocSinh()
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection(); con.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ThemHocSinh";
            cmd.Connection = con;
            cmd.Parameters.Add("@MaHS", SqlDbType.Char, 10).Value = textBoxMaHS.Text;
            cmd.Parameters.Add("@HoTenHS", SqlDbType.NVarChar, 100).Value = textBoxHoTenHS.Text;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = textBoxDiaChi.Text;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = comboBoxGioiTinh.SelectedItem;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = textBoxEmail.Text;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar, 30).Value = textBoxMatKhau.Text;
            cmd.Parameters.Add("@SDT", SqlDbType.Char, 10).Value = textBoxSDT.Text;

            int ret = cmd.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private string SinhMa()
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            int newCode = 1;

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select hs.MaHS from dbo.HOCSINH hs order by hs.MaHS", con);
            DataTable hs = new DataTable();
            adapter.Fill(hs);
            for (int i = 0; i < hs.Rows.Count; i++)
            {
                hs.Rows[i]["MaHS"] = hs.Rows[i]["MaHS"].ToString().Substring(2, 3);
            }
            for (int i = 0; i < hs.Rows.Count; i++)
            {
                if (newCode != Int32.Parse(hs.Rows[i]["MaHS"].ToString())) break;
                else newCode++;
            }
            con.Close();
            if (newCode >= 100)
                return String.Concat("HS", newCode.ToString());
            else if (newCode >= 10)
                return String.Concat("HS0", newCode.ToString());
            else
                return String.Concat("HS00", newCode.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxMaHS.Text = "";
            textBoxHoTenHS.Text = "";
            textBoxEmail.Text = "";
            textBoxMatKhau.Text = "";
            textBoxDiaChi.Text = "";
            dateTimePickerNgaySinh.Value = DateTime.Now;
            comboBoxGioiTinh.Text = "";
            textBoxSDT.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
