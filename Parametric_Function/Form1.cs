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
    public partial class Form1 : Form
    {
        //private MyTree X, Y;
        //private Paint draw;
        private ActForm act;
        public Form1()
        {
            InitializeComponent();
            //Y = new MyTree();
            //draw = new Paint(TreePic.Width, TreePic.Height);
            act = new ActForm(TreePic.Width, TreePic.Height);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Parsing_Click(object sender, EventArgs e)
        {
            //X = new MyTree();
            //X.Parser(XInput.Text);
            try
            {
                act.XParsing(XInput.Text);
                //TreePic.Image = draw.Draw(X.top);
                //Aswer.Text = X.Operation(X.top).ToString();
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
    }
}
