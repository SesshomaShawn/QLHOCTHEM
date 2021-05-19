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
    public partial class Quanlyhocphi : UserControl
    {
        private Connection cn;
        private string nam = "";
        private string thang = "";

        public Quanlyhocphi()
        {
            cn = new Connection();
            InitializeComponent();
        }

        private void loadDSGV()
        {
            nam = cbbNam.SelectedItem.ToString();
            thang = cbbThang.SelectedItem.ToString();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_TimHocPhiHS_AD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tukhoa", txt_TenHS.Text));
            cmd.Parameters.Add(new SqlParameter("@thang", thang));
            cmd.Parameters.Add(new SqlParameter("@nam", nam));
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDSHS.DataSource = dt;
          
            con.Close();
        }

        private void Phieuluong_Load(object sender, EventArgs e)
        {
            dgvDSHS.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDSHS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDSHS.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDSHS.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDSHS.BackgroundColor = Color.White;
            dgvDSHS.EnableHeadersVisualStyles = false;
            dgvDSHS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDSHS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDSHS.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dgvDSHS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
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
            btn.DisplayIndex = dgvDSHS.ColumnCount;
            dgvDSHS.Columns.Add(btn);
            dgvDSHS.Columns["Butt"].DisplayIndex = 0;
        }


        private void dgvDSGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void dgvDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString() == "Đã nộp")
            {

                var ten = dgvDSHS.Rows[e.RowIndex].Cells["MaHs"].Value.ToString();
                nam = cbbNam.SelectedItem.ToString();
                thang = cbbThang.SelectedItem.ToString();
                HoaDon hd = new HoaDon(ten, thang, nam);
                hd.ShowDialog();
               // loadDSGV();

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString() == "Chưa nộp")
            {
                var ten = dgvDSHS.Rows[e.RowIndex].Cells["MaHs"].Value.ToString();
                nam = cbbNam.SelectedItem.ToString();
                thang = cbbThang.SelectedItem.ToString();
                HoaDon hd = new HoaDon(ten, thang, nam);

                hd.ShowDialog();
               // loadDSGV();

            }
        }

        private void dgvDSHS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dgvDSHS.Columns[e.ColumnIndex].Name == "Butt" && dgvDSHS.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString() == "Đã nộp") // Also you can check for specific row by e.RowIndex
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
                    & ~(DataGridViewPaintParts.ContentForeground));
                var r = e.CellBounds;
                r.Inflate(-4, -4);
                e.Graphics.FillRectangle(Brushes.Green, r);
                e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
                e.Handled = true;


            }
            if (dgvDSHS.Columns[e.ColumnIndex].Name == "Butt" && dgvDSHS.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString() == "Chưa nộp") // Also you can check for specific row by e.RowIndex
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

        private void cbbThang_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void cbbNam_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }
    }
}
