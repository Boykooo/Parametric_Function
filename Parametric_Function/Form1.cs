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
    public partial class Form1 : Form, IForm
    {
        private ActForm act;
        public Form1()
        {
            InitializeComponent();
            //Y = new MyTree();
            //draw = new Paint(TreePic.Width, TreePic.Height);
            act = new ActForm(PicBox.Width, PicBox.Height, this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Parsing_Click(object sender, EventArgs e)
        {
            try
            {
                string x = XInput.Text.Replace(" ", "");
                string y = YInput.Text.Replace(" ", "");
                x = x.ToLower();
                y = y.ToLower();
                act.Parsing(x, y);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void XTree_Click(object sender, EventArgs e)
        {
            act.ShowTree(Expr.X);
        }
        private void YTree_Click(object sender, EventArgs e)
        {
            act.ShowTree(Expr.Y);
        }
        public void ReDraw(Bitmap bt)
        {
            PicBox.Image = bt;
        }
    }
}
