using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class Quanlyluong : UserControl
    {
        private Connection cn;
        private string nam = "", thang = "";

        public Quanlyluong()
        {
            cn = new Connection();
            InitializeComponent();
        }

        private void loadDSGV()
        {
            nam = cbbNam.SelectedItem.ToString();
            thang = cbbThang.SelectedItem.ToString();
            if (thang.Length < 2) thang = "0" + thang;
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection(); con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_TimLuongGV_AD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tukhoa", txt_TenGV.Text));
            cmd.Parameters.Add(new SqlParameter("@thang", thang));
            cmd.Parameters.Add(new SqlParameter("@nam", nam));
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDSGV.DataSource = dt;
            con.Close();
        }

        private void Phieuluong_Load(object sender, EventArgs e)
        {
            dgvDSGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDSGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDSGV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDSGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDSGV.BackgroundColor = Color.White;
            dgvDSGV.EnableHeadersVisualStyles = false;
            dgvDSGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDSGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDSGV.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dgvDSGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            loadDSGV();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "Butt";
            btn.Text = "Chi tiết";
            btn.Width = 80;
            btn.FlatStyle = FlatStyle.Flat;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.UseColumnTextForButtonValue = true;
            btn.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dgvDSGV.Columns.Add(btn);
            dgvDSGV.Columns["Butt"].DisplayIndex = 0;
        }


        private void dgvDSGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dgvDSGV.Columns[e.ColumnIndex].Name == "Butt" && dgvDSGV.Rows[e.RowIndex].Cells["TT"].Value.ToString() == "Đã trả") // Also you can check for specific row by e.RowIndex
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
                    & ~(DataGridViewPaintParts.ContentForeground));
                var r = e.CellBounds;
                r.Inflate(-4, -4);
                e.Graphics.FillRectangle(Brushes.Green, r);
                e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
                e.Handled = true;


            }
            if (dgvDSGV.Columns[e.ColumnIndex].Name == "Butt" && dgvDSGV.Rows[e.RowIndex].Cells["TT"].Value.ToString() == "Chưa trả") // Also you can check for specific row by e.RowIndex
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
                    & ~(DataGridViewPaintParts.ContentForeground));
                var r = e.CellBounds;
                r.Inflate(-4, -4);
                e.Graphics.FillRectangle(Brushes.Red, r);
                e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
                e.Handled = true;
            }
        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Rows[e.RowIndex].Cells["TT"].Value.ToString() == "Đã trả")
            {

                var ma = dgvDSGV.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
                nam = cbbNam.SelectedItem.ToString();
                thang = cbbThang.SelectedItem.ToString();
                PhieuLuong pl = new PhieuLuong(ma, thang, nam);
                //MessageBox.Show(ma + ", " + thang + "/" + nam);
                pl.ShowDialog();
                //loadDSGV();

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Rows[e.RowIndex].Cells["TT"].Value.ToString() == "Chưa trả")
            {
                var ma = dgvDSGV.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
                nam = cbbNam.SelectedItem.ToString();
                thang = cbbThang.SelectedItem.ToString();
                PhieuLuong pl = new PhieuLuong(ma, thang, nam);
                //MessageBox.Show(ma + ", " + thang + "/" + nam);
                pl.ShowDialog();
                //loadDSGV();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }
    }
}
