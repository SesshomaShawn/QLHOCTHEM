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
    public partial class DoiMatKhau : UserControl
    {
        private Connection cn;
        public string Ten = "";
        public string pass = "";
        public DoiMatKhau()
        {
            cn = new Connection();
            InitializeComponent();
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            FormDN formDN = new FormDN();
            DataTable dataTable = formDN.Bang();

            if (Pass_cu.Text == "")
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ!");
            else if (Pass_moi.Text == "")
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!");
            else if (Xacthuc.Text == "")
                MessageBox.Show("Bạn chưa xác thực lại mật khẩu!");
            else if (Pass_moi.Text != Xacthuc.Text)
                MessageBox.Show("Xác thực không trùng khớp");
            else if (Pass_cu.Text != pass)
                MessageBox.Show("Mật khẩu vừa nhập không đúng!");
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con = cn.GetConnection();
                    SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = "UPDATE HOCSINH SET MatKhau =  '"+Pass_moi.Text+"'  WHERE Email =  '"+Txt_Email.Text+ "'" ;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        //string ten = ((string)dataTable.Rows[i]["TenDN"]).Trim();
                        if (Ten == ((string)dataTable.Rows[i]["TenDN"]).Trim())
                        {
                            if((string)dataTable.Rows[i]["PhanQuyen"] == "HocSinh")
                            {
                                cmd.CommandText = "CHANGE_PASS";
                            }
                            else if((string)dataTable.Rows[i]["PhanQuyen"] == "GiaoVien")
                            {
                                cmd.CommandText = "CHANGE_PASSGV";
                            }
                        }
                    }
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@New_pass", Pass_moi.Text));
                    cmd.Parameters.Add(new SqlParameter("@Mail", Txt_Email.Text));
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Dispose();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("ERROR!");
                }
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
          
            Txt_Email.Text = Ten;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
