using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
     public partial class Thongke : UserControl
     {
          public Thongke()
          {
               InitializeComponent();
          }

        private void Thongke_Load(object sender, EventArgs e)
        {

        }
        private static Thongke _instance;
          public static Thongke Instance
          {
               get
               {
                    if (_instance == null)
                    {
                         _instance = new Thongke(); ;
                    }
                    return _instance;
               }
          }

          private void button1_Click(object sender, EventArgs e)
          {
               TK_HocSinh hs = new TK_HocSinh();
               if (!panel1.Controls.Contains(hs))
               {
                    panel1.Controls.Add(hs);
                    hs.Dock = DockStyle.Fill;
                    hs.BringToFront();
               }
               else
                    hs.BringToFront();
          }

         
        private void button4_Click(object sender, EventArgs e)
        {

               TK_TL_TP hd = new TK_TL_TP();
               if (!panel1.Controls.Contains(hd))
               {
                    panel1.Controls.Add(hd);
                    hd.Dock = DockStyle.Fill;
                    hd.BringToFront();
               }
               else
                    hd.BringToFront();
          }

        private void button2_Click(object sender, EventArgs e)
        {
            TK_GiaoVien gv = new TK_GiaoVien();
            if (!panel1.Controls.Contains(gv))
            {
                panel1.Controls.Add(gv);
                gv.Dock = DockStyle.Fill;
                gv.BringToFront();
            }
            else
                gv.BringToFront();
        }
    }
}
