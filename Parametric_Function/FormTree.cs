using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametric_Function
{
    public partial class FormTree : Form
    {
        public FormTree()
        {
            InitializeComponent();
        }
        private void FormTree_Load(object sender, EventArgs e)
        {

        }
        public void RePic(Bitmap bt)
        {
            pictureBox1.Image = bt;
        }
    }
}
