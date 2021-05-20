using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class HoaDon : Form
    {
        private Connection cn;

        private string thang;
        private string nam;
        private int tongtiet;
        private int tongtien;
        private string ma;
        private DataTable dta;
        private DataTable dsa;

        public HoaDon(string ten, string thang, string nam)
        {
            cn = new Connection();
            InitializeComponent();
            this.ma = ten;
            this.thang = thang;
            this.nam = nam;
            tbTenHS.Text = this.ma;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            if (thang.Length < 2) thang = "0" + thang;

            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ChiTietHDHS_AD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHS", ma));
            cmd.Parameters.Add(new SqlParameter("@thang", thang));
            cmd.Parameters.Add(new SqlParameter("@nam", nam));
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dta = dt;
            dataGridView1.DataSource = dt;
            con.Close();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "sp_ChungHDHS_AD";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add(new SqlParameter("@MaHS", ma));
            cmd1.Parameters.Add(new SqlParameter("@thang", thang));
            cmd1.Parameters.Add(new SqlParameter("@nam", nam));
            cmd1.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataTable ds = new DataTable();
            ad.Fill(ds);
            dsa = ds;
            con.Close();
          //  try
          //  {
                tbMaHD.Text = ds.Rows[0][0].ToString();
                tbMaHS.Text = ds.Rows[0][1].ToString();
                tbTenHS.Text = ds.Rows[0][2].ToString();
            try
            {
                dateTimePicker1.Value = DateTime.Parse(ds.Rows[0][4].ToString());

            } catch
            {
                label5.Visible = false;
                dateTimePicker1.Visible = false;
                button1.Visible = true;
            }

                dateTimePicker2.Value = DateTime.Parse(ds.Rows[0][3].ToString());
            //MessageBox.Show(dateTimePicker2.Value.ToString());
                tbSDT.Text = ds.Rows[0][5].ToString();

                int nCount = dataGridView1.RowCount;
                for (int i = 0; i < nCount - 1; i++)
                {
                    int i_sotiet = int.Parse(dataGridView1.Rows[i].Cells["TongSoTiet"].Value.ToString());
                    int i_sotien = int.Parse(dataGridView1.Rows[i].Cells["SoTien"].Value.ToString());
                    tongtiet += i_sotiet;
                    tongtien += i_sotiet * i_sotien;
                }

                tbTongTiet.Text = tongtiet.ToString();
                tbTongTien.Text = formatDecimal(tongtien.ToString());
           /* } catch (Exception)
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }*/

        }

        public string formatDecimal(string s)
        {
            string stmp = s;
            int amount;
            amount = (int)(s.Length / 3);
            if (s.Length % 3 == 0)
                amount--;
            for (int i = 1; i <= amount; i++)
            {
                stmp = stmp.Insert(stmp.Length - 4 * i + 1, ",");
            }
            return stmp;
        }


        #region begin
        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            /*COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int hang = 0, cot = 0;
            DataTable tblThongtinHang = dta;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 20;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Trung tâm Vinschool";
            exRange.Range["B2:B2"].MergeCells = true;
            exRange.Range["B2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B2:B2"].Value = "236 HQV- Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (+84)904841221";
            exRange.Range["D2:E2"].Font.Size = 16;
            exRange.Range["D2:E2"].Font.Bold = true;
            exRange.Range["D2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["D2:E2"].MergeCells = true;
            exRange.Range["D2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:E2"].Value = "HÓA ĐƠN";
            exRange.Range["A19:C19"].MergeCells = true;
            exRange.Range["A19:C19"].Font.Italic = true;
            exRange.Range["A19:C19"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A19:C19"].Value = "Người trả";
            exRange.Range["A23:C23"].MergeCells = true;
            exRange.Range["A23:C23"].Font.Italic = true;
            exRange.Range["A23:C23"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A23:C23"].Value = tbTenHS.Text;
            // Biểu diễn thông tin chung của hóa đơn bán

            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = dsa.Rows[0][1].ToString();
            exRange.Range["B7:B7"].Value = "Tên học sinh:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = ten;

            exRange.Range["B8:B8"].Value = "Email:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = dsa.Rows[0][3].ToString();
            //Lấy thông tin các mặt hàng

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["C11:C11"].Value = "Mã môn học";
            exRange.Range["B11:B11"].Value = "Tên môn học";
            exRange.Range["D11:D11"].Value = "Số buổi học";
            exRange.Range["E11:E11"].Value = "Số tiền 1 tiết";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange.Range["A12:B13"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E12:F13"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tongtien;
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + ChuyenSoSangChuoi(tongtien);
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(dsa.Rows[0][0].ToString());
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Người xuất";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = "Nguyễn Văn Á";
            exSheet.Name = "Phiếu lương";
            exApp.Visible = true;*/
        }
        //123 => một trăm hai ba đồng
        //1,123,000=>một triệu một trăm hai ba nghìn đồng
        //1,123,345,000 => một tỉ một trăm hai ba triệu ba trăm bốn lăm ngàn đồng
        string[] mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
        //Viết hàm chuyển số hàng chục, giá trị truyền vào là số cần chuyển và một biến đọc phần lẻ hay không ví dụ 101 => một trăm lẻ một
        private string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
            //Hàm để lấy số hàng chục ví dụ 21/10 = 2
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
            //Lấy số hàng đơn vị bằng phép chia 21 % 10 = 1
            Int64 donvi = (Int64)so % 10;
            //Nếu số hàng chục tồn tại tức >=20
            if (chuc > 1)
            {
                chuoi = " " + mNumText[chuc] + " mươi";
                if (donvi == 1)
                {
                    chuoi += " mốt";
                }
            }
            else if (chuc == 1)
            {//Số hàng chục từ 10-19
                chuoi = " mười";
                if (donvi == 1)
                {
                    chuoi += " một";
                }
            }
            else if (daydu && donvi > 0)
            {//Nếu hàng đơn vị khác 0 và có các số hàng trăm ví dụ 101 => thì biến daydu = true => và sẽ đọc một trăm lẻ một
                chuoi = " lẻ";
            }
            if (donvi == 5 && chuc >= 1)
            {//Nếu đơn vị là số 5 và có hàng chục thì chuỗi sẽ là " lăm" chứ không phải là " năm"
                chuoi += " lăm";
            }
            else if (donvi > 1 || (donvi == 1 && chuc == 0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }
        private string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng trăm ví du 434 / 100 = 4 (hàm Floor sẽ làm tròn số nguyên bé nhất)
            Int64 tram = Convert.ToInt64(Math.Floor((double)so / 100));
            //Lấy phần còn lại của hàng trăm 434 % 100 = 34 (dư 34)
            so = so % 100;
            if (daydu || tram > 0)
            {
                chuoi = " " + mNumText[tram] + " trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }
        private string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng triệu
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so / 1000000));
            //Lấy phần dư sau số hàng triệu ví dụ 2,123,000 => so = 123,000
            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " triệu";
                daydu = true;
            }
            //Lấy số hàng nghìn
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
            //Lấy phần dư sau số hàng nghin 
            so = so % 1000;
            if (nghin > 0)
            {
                chuoi += DocHangTram(nghin, daydu) + " nghìn";
                daydu = true;
            }
            if (so > 0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }
        public string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                //Lấy số hàng tỷ
                ty = Convert.ToInt64(Math.Floor((double)so / 1000000000));
                //Lấy phần dư sau số hàng tỷ
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " tỷ";
            } while (ty > 0);
            return chuoi + " đồng";
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from dbo.HOADON where MaHD = '" + tbMaHD.Text + "'";
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hủy hóa đơn thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Hóa đơn chưa được hủy");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            //MessageBox.Show(d.ToString());
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection();
            con.Open();
            //MessageBox.Show(tbMaHD.Text + "," + d.ToString("yyyy-MM-dd") + ", " + dateTimePicker2.Value.ToString() + ", " + Convert.ToInt32(tongtien.ToString()) + ", " + tbMaHS.Text);
            SqlCommand cmd = new SqlCommand("UPDATE HOADON SET NgayNop=@NgayNop,NgayXuat=@NgayXuat,SoTienNop=@SoTienNop, TinhTrang=@TinhTrang, MaHS=@MaHS WHERE (MaHD=@MaHD)", con);

            cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
            cmd.Parameters.AddWithValue("@NgayNop", d.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@NgayXuat", dateTimePicker2.Value.ToString());
            cmd.Parameters.AddWithValue("@SoTienNop", Convert.ToInt32(tongtien.ToString()));
            cmd.Parameters.AddWithValue("@TinhTrang", "Đã nộp");
            cmd.Parameters.AddWithValue("@MaHS", tbMaHS.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công!");
        }
    }
}
