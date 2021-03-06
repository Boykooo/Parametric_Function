﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Parametric_Function
{
    class Paint
    {
        private Point center;
        private Bitmap mainBT;
        private Pen myPen;
        private int diam = 40, padding = 50; // отступ наверно
        private int wh, ht;
        private Pen penGraph;
        public Paint(int wh, int ht)
        {
            mainBT = new Bitmap(wh, ht);
            this.wh = wh;
            this.ht = ht;
            myPen = new Pen(Color.Blue, 2.1F);
            center = new Point(wh / 2, ht / 2);
            penGraph = new Pen(Color.Blue, 2.5f);
        }
        public Bitmap DrawTree(Node top)
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
        public Bitmap DrawGraph(PointF[] arrPoints, float scale)
        {
            PointF[] scalePoint = arrPoints;
            using (Graphics g = Graphics.FromImage(mainBT))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.White);
                DrawAxis(g);
                for (int i = 0; i < scalePoint.Length; i++)
                {
                    scalePoint[i].X *= scale;
                    scalePoint[i].Y *= -scale; // перевод в адекватные координаты
                    scalePoint[i].X += center.X;
                    scalePoint[i].Y += center.Y;
                }
                g.DrawCurve(penGraph, scalePoint);
            }
            return mainBT;
        }
        private void DrawAxis(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(0, center.Y), new Point(center.X * 2, center.Y));
            g.DrawLine(Pens.Black, new Point(center.X, 0), new Point(center.X, center.Y * 2));
        }
    }
}
