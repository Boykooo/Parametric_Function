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
    public partial class MainForm : Form, IForm
    {
        private ActForm act;
        public MainForm()
        {
            InitializeComponent();
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
                act.Parsing(x, y, Convert.ToInt32(StartBox.Text), Convert.ToInt32(EndBox.Text), Convert.ToDouble(StepBox.Text));
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
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            act.Scale = trackBar1.Value;
        }
        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.X + ";" + e.Y;
        }
    }
}
/*
        Сердце
        x = 16*sin(t)^3
        t = 13*cos(t)-5*cos(2*t)-2*cos(3*t)-cos(4*t)
*/