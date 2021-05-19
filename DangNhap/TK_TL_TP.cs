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
using Microsoft.SqlServer.Server;

namespace DangNhap
{
     public partial class TK_TL_TP : UserControl
     {
        private Connection cn;
          private string thang;
          private string nam;
          public TK_TL_TP()
          {
            cn = new Connection();
            InitializeComponent();
          }
          private static TK_TL_TP _instance;
          public static TK_TL_TP Instance
          {
               get
               {
                    if (_instance == null)
                    {
                         _instance = new TK_TL_TP(); ;
                    }
                    return _instance;
               }
          }

          private void TK_TL_TP_Load(object sender, EventArgs e)
          {
            nam = cbbNam.SelectedItem.ToString();
            thang = cbbThang.SelectedItem.ToString();
            LoadDL();
          }

          private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
          {
               LoadDL();  
          }
          private void LoadDL()
          {
            SqlConnection con = new SqlConnection();
            try
               {
                nam = cbbNam.SelectedItem.ToString();
                thang = cbbThang.SelectedItem.ToString();
                if (thang.Length < 2) thang = "0" + thang;  
                    SqlCommand cmd = new SqlCommand();
                    
                    con = cn.GetConnection();
                    cmd.CommandText = "sp_ChiThuThang_AD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@THANG", thang));
                    cmd.Parameters.Add(new SqlParameter("@NAM", nam));
                    cmd.Connection = con;
                    con.Open();
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ds.Fill(dt);
                    chart1.DataSource = ds;
                    chart1.Series["Đồng"].XValueMember = "ThongKe";
                    chart1.Series["Đồng"].YValueMembers = "TongTien";
                    chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisY.Maximum = 250000000;
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    textBox1.Text = formatDecimal( dt.Rows[0][1].ToString()) ;
                    textBox2.Text = formatDecimal(dt.Rows[1][1].ToString());
                    textBox3.Text = formatDecimal((Convert.ToInt64(dt.Rows[0][1]) - Convert.ToInt64(dt.Rows[1][1])).ToString());
                    con.Close();

               }
               catch
               {
                con.Close();
                MessageBox.Show("Dữ liệu không tồn tại");
               }
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

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDL();
        }
    }
}
