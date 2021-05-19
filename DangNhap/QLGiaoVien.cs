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
	public partial class QLGiaoVien : UserControl
	{

		  private Connection cn;
		  SqlCommand cmd = new SqlCommand();
		  private static SqlDataAdapter adapter = null;
		  private static DataSet dataSet = null;

		  int vt = -1;
		  //Vị trí chọn trên DataGridViewGiaoVien

		  private static GiaoVien _instance;
		  public static GiaoVien Instance
		  {
			   get
			   {
					if (_instance == null)
					{
						 _instance = new GiaoVien(); ;
					}
					return _instance;
			   }
		  }

		  public static SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
		  public static DataSet DataSet { get => dataSet; set => dataSet = value; }

		  public QLGiaoVien()
		  {
			cn = new Connection();
			InitializeComponent();
			   LoadGiaoVien();
		  }
		  private void LoadGiaoVien()
		  {
			SqlConnection con = new SqlConnection();
			con = cn.GetConnection();

			adapter = new SqlDataAdapter("Select * from GIAOVIEN", con);
			   //adapter nay co the insert, update, delete
			   SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

			   dataSet = new DataSet();
			   //Do table vao DataSet
			   adapter.Fill(dataSet, "GiaoVien");

			   //dataGridViewGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			   dataGridViewGV.DataSource = dataSet.Tables["GiaoVien"];
		  }

		  private void GiaoVien_Load(object sender, EventArgs e)
		  {
			   //LoadGiaoVien();
		  }

		  private void TimKiemGV(string GV)
		  { 
				SqlConnection con = new SqlConnection();
				con = cn.GetConnection(); con.Open();
			cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			if ((string)comboBoxLoaiTimKiem.SelectedItem == @"Tên giáo viên")
			   {
					
					cmd.CommandText = "sp_TimKiemTenGV";
					cmd.Connection = con;
					cmd.Parameters.Add("@TenGV", SqlDbType.NVarChar, 100).Value = GV;
					
			   }
			   else if ((string)comboBoxLoaiTimKiem.SelectedItem == @"Mã giáo viên")
			   {
					
					cmd.CommandText = "sp_TimKiemMaGV";
					cmd.Connection = con;
					cmd.Parameters.Add("@MaGV", SqlDbType.Char, 10).Value = GV;
				
			   } else
				{
				cmd.CommandText = "sp_TimKiemBatki";
				cmd.Connection = con;
				cmd.Parameters.Add("@text", SqlDbType.NVarChar, 100).Value = GV;
				
			}
			adapter = new SqlDataAdapter(cmd);
			//adapter nay co the insert, update, delete
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

			dataSet = new DataSet();
			adapter.Fill(dataSet, "GiaoVien");
			dataGridViewGV.DataSource = dataSet.Tables["GiaoVien"];

			con.Close();
		}

		  private void comboBoxLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
		  {

		  }

		  //private void buttonOk_Click(object sender, EventArgs e)
		  //{
		  //     string GV = textBoxTimKiem.Text;
		  //     TimKiemGV(GV);
		  //}

		  private void buttonThem_Click(object sender, EventArgs e)
		  {
			   ThemGV themGV = new ThemGV();
			   themGV.ShowDialog();
				LoadGiaoVien();
		  }

		private void buttonXoa_Click(object sender, EventArgs e)
		 {
			if (vt == -1)
					return;

			SqlConnection con = new SqlConnection();
			con = cn.GetConnection(); con.Open();
			   cmd = new SqlCommand();
			   cmd.CommandType = CommandType.StoredProcedure;
			   cmd.CommandText = "sp_XoaGiaoVien";
			   cmd.Connection = con;

			   cmd.Parameters.Add("@MaGV", SqlDbType.Char, 10).Value = dataSet.Tables["GiaoVien"].Rows[vt]["MaGV"];
				try
				{
					cmd.ExecuteNonQuery();
					MessageBox.Show("Xóa thành công");
					LoadGiaoVien();
				}	catch (Exception)
				{
					MessageBox.Show("Xóa thất bại");
				}
		  }

		  private void dataGridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
		  {
			   vt = e.RowIndex;
		  }

		  private void buttonSua_Click(object sender, EventArgs e)
		  {
			   if (vt == -1)
					return;

			   dataSet.Tables["GiaoVien"].Rows[vt]["MaGV"] = dataGridViewGV.Rows[vt].Cells["MaGV"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["HoTenGV"] = dataGridViewGV.Rows[vt].Cells["HoTenGV"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["NgaySinh"] = dataGridViewGV.Rows[vt].Cells["NgaySinh"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["DiaChi"] = dataGridViewGV.Rows[vt].Cells["DiaChi"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["GioiTinh"] = dataGridViewGV.Rows[vt].Cells["GioiTinh"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["MaMH"] = dataGridViewGV.Rows[vt].Cells["MaMH"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["MatKhau"] = dataGridViewGV.Rows[vt].Cells["MatKhau"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["Email"] = dataGridViewGV.Rows[vt].Cells["Email"].Value;
			   dataSet.Tables["GiaoVien"].Rows[vt]["MaDM"] = dataGridViewGV.Rows[vt].Cells["MaDM"].Value;
				dataSet.Tables["GiaoVien"].Rows[vt]["SDT"] = dataGridViewGV.Rows[vt].Cells["SDT"].Value;  
			   adapter.Update(dataSet, "GiaoVien");
			   MessageBox.Show("Đã sửa thành công");
			   LoadGiaoVien();
		  }

		private void QLGiaoVien_Load(object sender, EventArgs e)
		{
			dataGridViewGV.BorderStyle = BorderStyle.None;
			dataGridViewGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dataGridViewGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dataGridViewGV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
			dataGridViewGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
			dataGridViewGV.BackgroundColor = Color.White;

			dataGridViewGV.EnableHeadersVisualStyles = false;
			dataGridViewGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
			dataGridViewGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		}

		private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
		{
			string GV = textBoxTimKiem.Text;
			TimKiemGV(GV);
		}

        private void dataGridViewGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex].Index == 0 && e.RowIndex >= 0)
			{
				string ma = dataGridViewGV.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
				DSLopHoc pl = new DSLopHoc(ma);
				pl.ShowDialog();
			}
		}
    }
}
