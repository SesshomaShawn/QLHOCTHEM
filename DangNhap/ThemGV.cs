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
    public partial class ThemGV : Form
    {
        private Connection cn;
        SqlCommand cmd = new SqlCommand();

        private static ThemGV _instance;
        public static ThemGV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThemGV(); ;
                }
                return _instance;
            }
        }
        public ThemGV()
        {
            cn = new Connection();
            InitializeComponent();
            textBoxMaGV.Text = SinhMa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemGiaoVien();
        }

        private void ThemGiaoVien()
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection(); con.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ThemGiaoVien";
            cmd.Connection = con;

            string MaMH = "";
            int i = comboBoxTenMH.SelectedIndex;
            switch (i)
            {
                    case 0:
                         MaMH = "MH01";
                         break;
                    case 1:
                         MaMH = "MH02";
                         break;
                    case 2:
                         MaMH = "MH03";
                         break;
                    case 3:
                         MaMH = "MH04";
                         break;
                    case 4:
                         MaMH = "MH05";
                         break;
            }

            string MaDM = "";
            int j = comboBoxSoTienDM.SelectedIndex;
            switch (j)
            {
                    case 0:
                         MaDM = "DM01";
                         break;
                    case 1:
                         MaDM = "DM02";
                         break;
                    case 2:
                         MaDM = "DM03";
                         break;
            }
            
            cmd.Parameters.Add("@MaGV", SqlDbType.Char, 10).Value = textBoxMaGV.Text;
            cmd.Parameters.Add("@HoTenGV", SqlDbType.NVarChar, 100).Value = textBoxHoTenGV.Text;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = textBoxDiaChi.Text;
            cmd.Parameters.Add("@SDT", SqlDbType.Char, 10).Value = textBoxSDT.Text;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = comboBoxGioiTinh.SelectedItem;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = textBoxEmail.Text;
            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 30).Value = textBoxMatKhau.Text;
            cmd.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = MaMH;
            cmd.Parameters.Add("@MaDM", SqlDbType.Char, 10).Value = MaDM;
            

            int ret = cmd.ExecuteNonQuery();
            if(ret > 0)
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
            SqlDataAdapter adapter = new SqlDataAdapter("select gv.MaGV from dbo.GIAOVIEN gv order by gv.MaGV", con);
            DataTable gv = new DataTable();
            adapter.Fill(gv);
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                gv.Rows[i]["MaGV"] = gv.Rows[i]["MaGV"].ToString().Substring(2, 3);
            }
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                if (newCode != Int32.Parse(gv.Rows[i]["MaGV"].ToString())) break; 
                else newCode++;
            }
            con.Close();
            if (newCode >= 100) 
                return String.Concat("GV", newCode.ToString());
            else if (newCode >= 10)
                return String.Concat("GV0", newCode.ToString());
            else
                return String.Concat("GV00", newCode.ToString());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBoxMaGV.Text = "";
            textBoxHoTenGV.Text = "";
            comboBoxTenMH.Text = "";
            comboBoxSoTienDM.Text = "";
            textBoxEmail.Text = "";
            textBoxMatKhau.Text = "";
            textBoxDiaChi.Text = "";
            dateTimePickerNgaySinh.Value = DateTime.Now;
            comboBoxGioiTinh.Text = "";
            textBoxSDT.Text = "";
        }
    }
}
