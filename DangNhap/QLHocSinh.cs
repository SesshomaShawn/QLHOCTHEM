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
    public partial class QLHocSinh : UserControl
    {
        private Connection cn;
        SqlCommand cmd = new SqlCommand();
          private static SqlDataAdapter adapter = null;
          private static DataSet dataSet = null;

          int vt = -1;
          //Vị trí chọn trên DataGridViewHS

          private static HocSinh _instance;
          public static HocSinh Instance
          {
               get
               {
                    if (_instance == null)
                    {
                         _instance = new HocSinh(); ;
                    }
                    return _instance;
               }
          }

          public static SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
          public static DataSet DataSet { get => dataSet; set => dataSet = value; }
          public QLHocSinh()
          {
            cn = new Connection();
            InitializeComponent();
               LoadHocSinh();
          }

          private void LoadHocSinh()
          {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();

            adapter = new SqlDataAdapter("Select * from HOCSINH", con);
               //adapter nay co the insert, update, delete
               SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

               dataSet = new DataSet();
               //Do table vao DataSet
               adapter.Fill(dataSet, "HocSinh");

               //dataGridViewHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               dataGridViewHS.DataSource = dataSet.Tables["HocSinh"];
          }

          private void panel2_Paint(object sender, PaintEventArgs e)
          {

          }

          private void TimKiemHS(string HS)
          {
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection(); con.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            if ((string)comboBoxLoaiTimKiem.SelectedItem == @"Tên học sinh")
            {

                cmd.CommandText = "sp_TimKiemTenHS";
                cmd.Connection = con;
                cmd.Parameters.Add("@TenHS", SqlDbType.NVarChar, 100).Value = HS;

            }
            else if ((string)comboBoxLoaiTimKiem.SelectedItem == @"Mã học sinh")
            {

                cmd.CommandText = "sp_TimKiemMaHS";
                cmd.Connection = con;
                cmd.Parameters.Add("@MaHS", SqlDbType.Char, 10).Value = HS;

            }
            else
            {
                cmd.CommandText = "sp_TimKiemBatkiHS";
                cmd.Connection = con;
                cmd.Parameters.Add("@text", SqlDbType.NVarChar, 100).Value = HS;

            }
            adapter = new SqlDataAdapter(cmd);
            //adapter nay co the insert, update, delete
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "HocSinh");
            dataGridViewHS.DataSource = dataSet.Tables["HocSinh"];

            con.Close();
        }

          //private void buttonOk_Click(object sender, EventArgs e)
          //{
          //     string HS = textBoxTimKiem.Text;
          //     TimKiemHS(HS);
          //}

          private void buttonThem_Click(object sender, EventArgs e)
          {
               ThemHS themHS = new ThemHS();
               themHS.ShowDialog();
            LoadHocSinh();
          }

          private void buttonXoa_Click(object sender, EventArgs e)
          {
               if (vt == -1)
                    return;

            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            if (con.State == ConnectionState.Closed)
                    con.Open();
               cmd = new SqlCommand();
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "sp_XoaHocSinh";
               cmd.Connection = con;

               cmd.Parameters.Add("@MaHS", SqlDbType.Char, 10).Value = dataSet.Tables["HocSinh"].Rows[vt]["MaHS"];

               int ret = cmd.ExecuteNonQuery();
               if (ret > 0)
               {
                    MessageBox.Show("Xóa thành công");
                    LoadHocSinh();
               }
               else
               {
                    MessageBox.Show("Xóa thất bại");
               }
          }

          private void dataGridViewHS_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               vt = e.RowIndex;
          }

          private void buttonSua_Click(object sender, EventArgs e)
          {
               if (vt == -1)
                    return;

               dataSet.Tables["HocSinh"].Rows[vt]["MaHS"] = dataGridViewHS.Rows[vt].Cells["MaHS"].Value;
               dataSet.Tables["HocSinh"].Rows[vt]["HoTenHS"] = dataGridViewHS.Rows[vt].Cells["HoTenHS"].Value;
               dataSet.Tables["HocSinh"].Rows[vt]["NgaySinh"] = dataGridViewHS.Rows[vt].Cells["NgaySinh"].Value;
               dataSet.Tables["HocSinh"].Rows[vt]["DiaChi"] = dataGridViewHS.Rows[vt].Cells["DiaChi"].Value;
               dataSet.Tables["HocSinh"].Rows[vt]["GioiTinh"] = dataGridViewHS.Rows[vt].Cells["GioiTinh"].Value;
               dataSet.Tables["HocSinh"].Rows[vt]["MatKhau"] = dataGridViewHS.Rows[vt].Cells["MatKhau"].Value;
               dataSet.Tables["HocSinh"].Rows[vt]["Email"] = dataGridViewHS.Rows[vt].Cells["Email"].Value; adapter.Update(dataSet, "HocSinh");
                dataSet.Tables["HocSinh"].Rows[vt]["SDT"] = dataGridViewHS.Rows[vt].Cells["SDT"].Value; adapter.Update(dataSet, "HocSinh");
                MessageBox.Show("Đã sửa thành công");
               LoadHocSinh();
          }

        private void QLHocSinh_Load(object sender, EventArgs e)
        {
            dataGridViewHS.BorderStyle = BorderStyle.None;
            dataGridViewHS.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewHS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHS.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewHS.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewHS.BackgroundColor = Color.White;

            dataGridViewHS.EnableHeadersVisualStyles = false;
            dataGridViewHS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewHS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string HS = textBoxTimKiem.Text;
            TimKiemHS(HS);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTimKiem_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewHS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Index == 0 && e.RowIndex >= 0 )
            {
                string ma = dataGridViewHS.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                DSLopHoc pl = new DSLopHoc(ma);
                pl.ShowDialog();
            }
        }
    }
}
