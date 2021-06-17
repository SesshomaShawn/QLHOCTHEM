using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
     public partial class FormDNAM : Form
     {
          public FormDNAM()
          {
                InitializeComponent();
                MacDinh();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
               QLHocSinh hs = new QLHocSinh();
               if (!panel3.Controls.Contains(hs))
               {
                    panel3.Controls.Add(hs);
                    hs.Dock = DockStyle.Fill;
                    hs.BringToFront();
               }
               else
                    hs.BringToFront();

               //if(!panel3.Controls.Contains(QLHocSinh.Instance))
               //{
               //    panel3.Controls.Add(QLHocSinh.Instance);
               //    QLHocSinh.Instance.Dock = DockStyle.Fill;
               //    QLHocSinh.Instance.BringToFront();
               //}
               //else
               //    QLHocSinh.Instance.BringToFront();
          }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
               QLGiaoVien gv = new QLGiaoVien();
               if (!panel3.Controls.Contains(gv))
               {
                    panel3.Controls.Add(gv);
                    gv.Dock = DockStyle.Fill;
                    gv.BringToFront();
               }
               else
                    gv.BringToFront();
               //if (!panel3.Controls.Contains(QLGiaoVien.Instance))
               //{
               //    panel3.Controls.Add(QLGiaoVien.Instance);
               //    QLGiaoVien.Instance.Dock = DockStyle.Fill;
               //    QLGiaoVien.Instance.BringToFront();
               //}
               //else
               //    QLGiaoVien.Instance.BringToFront();

          }

          private void button5_Click(object sender, EventArgs e)
          {
               Quanlyluong pl = new Quanlyluong();
               if (!panel3.Controls.Contains(pl))
               {
                    panel3.Controls.Add(pl);
                    pl.Dock = DockStyle.Fill;
                    pl.BringToFront();
               }
               else
                    pl.BringToFront();
          }

          private void button6_Click(object sender, EventArgs e)
          {
               Quanlyhocphi hd = new Quanlyhocphi();
               if (!panel3.Controls.Contains(hd))
               {
                    panel3.Controls.Add(hd);
                    hd.Dock = DockStyle.Fill;
                    hd.BringToFront();
               }
               else
                    hd.BringToFront();
          }

        private void button2_Click(object sender, EventArgs e)
        {
            //AnLichHoc();
            if (!panel3.Controls.Contains(Lichhoc.Instance))
            {
                panel3.Controls.Add(Lichhoc.Instance);
                Lichhoc.Instance.Dock = DockStyle.Fill;
                Lichhoc.Instance.BringToFront();
            }
            else
                Lichhoc.Instance.BringToFront();
        }
          public void MacDinh()
          {
               pn_LichHoc.Visible = false;
          }
          public void AnLichHoc()
          {
               if (pn_LichHoc.Visible == true)
                    pn_LichHoc.Visible = false;
          }
          public void HienLichHoc()
          {
               if (pn_LichHoc.Visible == false)
               {
                    AnLichHoc();
                    pn_LichHoc.Visible = true;
               }
               else pn_LichHoc.Visible = false;
          }

          private void btnXemLichHoc(object sender, EventArgs e)
          {
               HienLichHoc();
          }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            Trong hd = new Trong();
            if (!panel3.Controls.Contains(hd))
            {
                panel3.Controls.Add(hd);
                hd.Dock = DockStyle.Fill;
                hd.BringToFront();
            }
            else
                hd.BringToFront();
            FormSaoLuu sl = new FormSaoLuu();
            sl.ShowDialog();

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thongke hd = new Thongke();
            if (!panel3.Controls.Contains(hd))
            {
                panel3.Controls.Add(hd);
                hd.Dock = DockStyle.Fill;
                hd.BringToFront();
            }
            else
                hd.BringToFront();
        }

        private void btn_PhysicAD_Click(object sender, EventArgs e)
        {
           // AnLichHoc();
            if (!panel3.Controls.Contains(Li.Instance))
            {
                panel3.Controls.Add(Li.Instance);
                Li.Instance.Dock = DockStyle.Fill;
                Li.Instance.BringToFront();
            }
            else
                Li.Instance.BringToFront();
        }

        private void btn_EnglishAD_Click(object sender, EventArgs e)
        {
          //  AnLichHoc();
            if (!panel3.Controls.Contains(Anh.Instance))
            {
                panel3.Controls.Add(Anh.Instance);
                Anh.Instance.Dock = DockStyle.Fill;
                Anh.Instance.BringToFront();
            }
            else
                Anh.Instance.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          //  AnLichHoc();
            if (!panel3.Controls.Contains(Van.Instance))
            {
                panel3.Controls.Add(Van.Instance);
                Van.Instance.Dock = DockStyle.Fill;
                Van.Instance.BringToFront();
            }
            else
                Van.Instance.BringToFront();
        }

        private void btn_ChemistryAD_Click(object sender, EventArgs e)
        {
          //  AnLichHoc();
            if (!panel3.Controls.Contains(Hoa.Instance))
            {
                panel3.Controls.Add(Hoa.Instance);
                Hoa.Instance.Dock = DockStyle.Fill;
                Hoa.Instance.BringToFront();
            }
            else
                Hoa.Instance.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDN dn = new FormDN();
            dn.ShowDialog();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.White;
        }

        private void btnGiaoVien_MouseEnter(object sender, EventArgs e)
        {
            btnGiaoVien.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnGiaoVien_MouseLeave(object sender, EventArgs e)
        {
            btnGiaoVien.BackColor = System.Drawing.Color.White;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.White;
        }

        private void XemLichHoc_MouseEnter(object sender, EventArgs e)
        {
            XemLichHoc.BackColor = System.Drawing.Color.LightBlue;
        }

        private void XemLichHoc_MouseLeave(object sender, EventArgs e)
        {
            XemLichHoc.BackColor = System.Drawing.Color.White;
        }

        private void btn_MathAD_MouseEnter(object sender, EventArgs e)
        {
            btn_MathAD.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_MathAD_MouseLeave(object sender, EventArgs e)
        {
            btn_MathAD.BackColor = System.Drawing.Color.White;
        }

        private void btn_PhysicAD_MouseEnter(object sender, EventArgs e)
        {
            btn_PhysicAD.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_PhysicAD_MouseLeave(object sender, EventArgs e)
        {
            btn_PhysicAD.BackColor = System.Drawing.Color.White;
        }

        private void btn_EnglishAD_MouseEnter(object sender, EventArgs e)
        {
            btn_EnglishAD.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_EnglishAD_MouseLeave(object sender, EventArgs e)
        {
            btn_EnglishAD.BackColor = System.Drawing.Color.White;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = System.Drawing.Color.White;
        }

        private void btn_ChemistryAD_MouseEnter(object sender, EventArgs e)
        {
            btn_ChemistryAD.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_ChemistryAD_MouseLeave(object sender, EventArgs e)
        {
            btn_ChemistryAD.BackColor = System.Drawing.Color.White;
        }

        private void btnHocSinh_MouseEnter(object sender, EventArgs e)
        {
            btnHocSinh.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnHocSinh_MouseLeave(object sender, EventArgs e)
        {
            btnHocSinh.BackColor = System.Drawing.Color.White;
        }

        private void btn_SaoLuu_MouseEnter(object sender, EventArgs e)
        {
            btn_SaoLuu.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_SaoLuu_MouseLeave(object sender, EventArgs e)
        {
            btn_SaoLuu.BackColor = System.Drawing.Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
        }

        private void btn_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = System.Drawing.Color.White;
        }
    }
}
