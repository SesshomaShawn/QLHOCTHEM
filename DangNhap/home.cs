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
    public partial class home : UserControl
    {
        private static home _instance;
        public static home Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new home(); ;
                }
                return _instance;
            }
        }
        private void home_load(object sender, EventArgs e)
        {

        }
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
