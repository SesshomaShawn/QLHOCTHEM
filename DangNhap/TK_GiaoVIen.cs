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
     public partial class TK_GiaoVien : UserControl
     {
        private Connection cn;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;
        public TK_GiaoVien()
        {
            cn = new Connection();
            InitializeComponent();
        }

        private void fillChart(int id)
        {

            SqlConnection con = new SqlConnection();
            con = cn.GetConnection(); con.Open();
            SqlCommand cmd = new SqlCommand();
                

            cmd.CommandType = CommandType.StoredProcedure;
            if (id == 0)
            {
                cmd.CommandText = "sp_TK_GV_MH_AD";
            } else if (id == 1)
            {
                cmd.CommandText = "sp_TK_GV_DM_AD";
            } else
            {
                cmd.CommandText = "sp_TK_GV_KH_AD";
            }
            cmd.Connection = con;
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "TableThongKeSoLuongGiaoVien");

            chartGV_Cot.DataSource = dataSet.Tables["TableThongKeSoLuongGiaoVien"];
            chartGV_Tron.DataSource = dataSet.Tables["TableThongKeSoLuongGiaoVien"];

            chartGV_Cot.Series["Số lượng GV"].XValueMember = "Loai";
            chartGV_Cot.Series["Số lượng GV"].YValueMembers = "SoLuong";

            chartGV_Tron.Series["Số lượng GV"].XValueMember = "Loai";
            chartGV_Tron.Series["Số lượng GV"].YValueMembers = "SoLuong";
            chartGV_Tron.Series["Số lượng GV"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartGV_Cot.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillChart(comboBox1.SelectedIndex);
        }

        private void chartGV_Tron_Click(object sender, EventArgs e)
        {
        }
    }
}
