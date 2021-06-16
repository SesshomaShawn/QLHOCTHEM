using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class Lop_DaDangKy : UserControl
    {
        private Connection cn;
        private string maHS = HocSinh.TimMaHS();
        private static Lop_DaDangKy _instance;
        public string MaHS { get => maHS; set => maHS = value; }
        public Lop_DaDangKy()
        {
            cn = new Connection();          
            InitializeComponent();
        }
        public static Lop_DaDangKy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lop_DaDangKy(); ;
                }
                return _instance;
            }
        }

        private void Lop_DaDangKy_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cbb_HS1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHS", SqlDbType.NChar, 10).Value = maHS;
            cmd.Connection = con;
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                //MessageBox.Show(row["TegnLMH"].ToString());
                comboTenLop.Items.Add(row["TenLMH"].ToString());
            }
        }

        private void comboTenLop_SelectedValueChanged(object sender, EventArgs e)
        {
          try
            {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "XemLichHoc_HS1";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHS", SqlDbType.Char, 10).Value = maHS;
                cmd.Parameters.Add("@TenLMH", SqlDbType.NVarChar,50).Value = comboTenLop.SelectedItem;
                cmd.Connection = con;
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewLopDaDangKy.DataSource = dt.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
        }

        private void dataGridViewLopDaDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewLopDaDangKy.Rows[e.RowIndex];
                textBoxSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                textBoxHoTen.Text = row.Cells["HoTenGV"].Value.ToString();
                textBox1MaLMH.Text = row.Cells["TenLMH"].Value.ToString();
                textBoxKipHoc.Text = row.Cells["KipHoc"].Value.ToString();
                textBoxMaLichHoc.Text = row.Cells["MaLichHoc"].Value.ToString();
                textBoxNgayHoc.Text = row.Cells["NgayHoc"].Value.ToString();
            }
        }

        private void comboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
    }
}
