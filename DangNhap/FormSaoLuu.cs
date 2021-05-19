using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class FormSaoLuu : Form
    {
        private Connection cn;
        public FormSaoLuu()
        {
            cn = new Connection();
            InitializeComponent();
        }

        private void btn_browser1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                btn_backup.Enabled = true;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
          /*  try
            {*/
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập đường dẫn để lưu!");
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con = cn.GetConnection();
                    string cmd = "BACKUP DATABASE [QLHOCTHEM] TO DISK = '" + textBox1.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyy-MM-dd-HH-mm-ss")+".bak'";
                    SqlCommand command = new SqlCommand(cmd,con);
                    if(con.State!= ConnectionState.Open)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!");
                    btn_backup.Enabled = false;

                }
            /*}
            catch
            {
                MessageBox.Show("Back up khong thanh cong!");
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_browser2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                btn_restore.Enabled = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
           
           
                try
                {
                SqlConnection con = new SqlConnection();
                con = cn.GetConnection();
                if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    string query1 = string.Format("ALTER DATABASE [QLHOCTHEM] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();

                    string query2 = "USE MASTER RESTORE DATABASE [QLHOCTHEM] FROM DISK='" + textBox2.Text + "'WITH REPLACE;";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();

                    string querry3 = string.Format("ALTER DATABASE [QLHOCTHEM] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(querry3, con);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Khôi phục cơ sở dữ liệu thành công!");
                    con.Close();

                }
                catch
                {
                    MessageBox.Show("Khôi phục cơ sở dữ liệu thất bại!");
                }
             
        }
    }
}
