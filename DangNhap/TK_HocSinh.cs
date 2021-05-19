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
     public partial class TK_HocSinh : UserControl
     {
        private Connection cn;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;
        public TK_HocSinh()
        {
            cn = new Connection();
            InitializeComponent();
        }
        private static TK_HocSinh _instance;
        public static TK_HocSinh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TK_HocSinh(); ;
                }
                return _instance;
            }
        }

        private void fillChart(int i)
        {
            string KhoiLop = "";
            if (i == 0)
            {
                KhoiLop = "KH01";
            } else if (i == 1)
            {
                KhoiLop = "KH02";
            } else
            {
                KhoiLop = "KH03";
            }
            //MessageBox.Show(KhoiLop);
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con = cn.GetConnection(); con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_TK_HS_MH_TheoKhoi_AD";
            cmd.Parameters.Add("@MaKhoi", SqlDbType.Char, 10).Value = KhoiLop;
           // MessageBox.Show(KhoiLop);
            cmd.Connection = con;

            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataSet = new DataSet();

            adapter.Fill(dataSet, "TableThongKeSoLuongHocSinh");

            chartHS_Cot.DataSource = dataSet.Tables["TableThongKeSoLuongHocSinh"];
            chartHS_Tron.DataSource = dataSet.Tables["TableThongKeSoLuongHocSinh"];


            chartHS_Cot.Series["Số lượng HS"].XValueMember = "TenLMH";
            chartHS_Cot.Series["Số lượng HS"].YValueMembers = "SoLuongHS";

            chartHS_Tron.Series["Số lượng HS"].XValueMember = "TenLMH";
            chartHS_Tron.Series["Số lượng HS"].YValueMembers = "SoLuongHS";
            chartHS_Tron.Series["Số lượng HS"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartHS_Cot.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            //chartHS_Cot.Visible = true;
            //chartHS_Cot.Titles.Add("Thống kê số lượng học sinh");

            

            con.Close();

        }

        private void comboBoxLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillChart(comboBoxLoaiThongKe.SelectedIndex);
        }
    }
}
