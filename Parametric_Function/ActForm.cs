using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Parametric_Function
{
    public enum Expr { X, Y }
    class ActForm
    {
        private FormTree tree;
        private TreeParsing Xpars;
        private TreeParsing Ypars;
        private Paint draw; 
        public ActForm(int wh, int ht)
        {
            draw = new Paint(wh, ht);
            Xpars = new TreeParsing();
            Ypars = new TreeParsing();
        }
        public void XParsing(string expr)
        {
            Xpars = new TreeParsing();
            Xpars.StartParsing(expr);
        }
        public void YParsing(string expr)
        {
            Ypars = new TreeParsing();
            Ypars.StartParsing(expr);
        }
        public void ShowTree(Expr ex)
        {
            tree = new FormTree();
            switch (ex)
            {
                case Expr.X:
                    tree.RePic(draw.Draw(Xpars.Top));
                    break;
                case Expr.Y:
                    tree.RePic(draw.Draw(Ypars.Top));
                    break;
            }
            tree.Show();
        }
        public Bitmap GetYPicture()
        {
            return draw.Draw(Ypars.Top);
        }
    }
}
