using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olympics
{
    public partial class About_UserControl1 : UserControl
    {
        private static About_UserControl1 _instance;
        public static About_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new About_UserControl1();
                }
                return _instance;
            }
        }
        public About_UserControl1()
        {
            InitializeComponent();
        }

        private void About_UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
