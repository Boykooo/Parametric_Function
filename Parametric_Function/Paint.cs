using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Parametric_Function
{
    class Paint
    {
        private Bitmap mainBT;
        private Pen myPen;
        private int diam = 40, padding = 50; // magic!
        private int wh, ht;
        public Paint(int wh, int ht)
        {
            mainBT = new Bitmap(wh, ht);
            this.wh = wh;
            this.ht = ht;
            myPen = new Pen(Color.Blue, 2.1F);
        }
        public Bitmap Draw(Node top)
        {
            using(Graphics g = Graphics.FromImage(mainBT))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.White);
                DrawNode(top, 0, wh, ht / 2, 5, g);
            }
            return mainBT;
        }
        private void DrawNode(Node node, int left, int right, int x, int y, Graphics g)
        {
            if (node != null)
            {
                g.DrawEllipse(myPen, x, y, diam, diam);
                if (node.left != null)
                {
                    g.DrawLine(myPen, x + diam / 2, y + diam / 2, x - (x - left) / 2 + diam / 2, y + padding + diam / 2);
                    DrawNode(node.left, left, x, x - (x - left) / 2, y + padding, g);

                }
                if (node.right != null)
                {
                    g.DrawLine(myPen, x + diam / 2, y + diam / 2, x + (right - x) / 2 + diam / 2, y + padding + diam / 2);
                    DrawNode(node.right, x, right, x + (right - x) / 2, y + padding, g);
                }
                g.FillEllipse(Brushes.Yellow, x, y, diam, diam);
                    g.DrawString(node.key.ToString(), new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(x + 5, y + 8));
                

            }
        }
    }
}
