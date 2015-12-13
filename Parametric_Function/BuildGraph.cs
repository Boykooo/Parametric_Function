using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Parametric_Function
{
    class BuildGraph
    {
        public PointF[] Build(TreeParsing x, TreeParsing y, int start, int end, double step)
        {
            PointF[] points = new PointF[Math.Abs(start) + Math.Abs(end)];
            double st = start;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = NewPoint(x, y, st, step);
                st += step;
            }
            return points;
        }
        private PointF NewPoint(TreeParsing x, TreeParsing y, double value, double step)
        {
            float xValue = 0;
            float yValue = 0;
            try
            {
                xValue = (float)x.GetValue(value);
                yValue = (float)y.GetValue(value);
            }
            catch
            {
                value += step;
                xValue = (float)x.GetValue(value);
                yValue = (float)y.GetValue(value);
            }
            return new PointF(xValue, yValue);
        }
    }
}
