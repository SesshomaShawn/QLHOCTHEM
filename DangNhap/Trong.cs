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
    public partial class Trong : UserControl
    {
        public Trong()
        {
            InitializeComponent();
        }
        private static Trong _instance;
        public static Trong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Trong(); ;
                }
                return _instance;
            }
        }
        private void Trong_Load(object sender, EventArgs e)
        {

        }
    }
}
