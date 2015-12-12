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
        private BuildGraph graph;
        private FormTree tree;
        private TreeParsing Xpars;
        private TreeParsing Ypars;
        private Paint draw;
        private IForm form;
        public ActForm(int wh, int ht, IForm form)
        {
            draw = new Paint(wh, ht);
            Xpars = new TreeParsing();
            Ypars = new TreeParsing();
            graph = new BuildGraph();
            this.form = form;
        }
        private void XParsing(string expr)
        {
            Xpars = new TreeParsing();
            Xpars.StartParsing(expr);
        }
        private void YParsing(string expr)
        {
            Ypars = new TreeParsing();
            Ypars.StartParsing(expr);
        }
        public void Parsing(string X, string Y)
        {
            XParsing(X);
            YParsing(Y);
            form.ReDraw(draw.DrawGraph(graph.Build(Xpars, Ypars)));
        }
        public void ShowTree(Expr ex)
        {
            tree = new FormTree();
            switch (ex)
            {
                case Expr.X:
                    tree.RePic(draw.DrawTree(Xpars.Top));
                    break;
                case Expr.Y:
                    tree.RePic(draw.DrawTree(Ypars.Top));
                    break;
            }
            tree.Show();
        }
    }
}
