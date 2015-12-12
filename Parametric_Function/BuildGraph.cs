using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Parametric_Function
{
    class BuildGraph
    {
        public PointF[] Build(TreeParsing x, TreeParsing y)
        {
            PointF[] points = new PointF[50];
            int value = -5;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = NewPoint(x, y, value);
                value += 1;
                if (value == 0)
                    value++;
            }
            return points;
        }
        private PointF NewPoint(TreeParsing x, TreeParsing y, int value)
        {
            float xValue = (float)x.GetValue(value);
            float yValue = (float)y.GetValue(value);
            return new PointF(xValue, yValue);
        }
    }
}
