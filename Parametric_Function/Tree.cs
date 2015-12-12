using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parametric_Function
{
    class TreeParsing
    {
        public Node Top { get; private set; }
        public TreeParsing()
        {
        }
        public void StartParsing(string expr)
        {
            int index = 0;
            Node tempTop = null;
            if (expr[index] != '(')
            {
                tempTop = CreateChildNode(expr, ref index);
                Node tempLastNode = tempTop, penult = tempTop;
                Parsing(ref tempTop, tempLastNode, penult, expr, ref index);
            }
            Top = tempTop;
        }
        private void Parsing(ref Node tempTop, Node lastNode, Node penult, string expr, ref int index)
        {
            if (index + 1 < expr.Length && expr[index] != ')')
            {
                int exprOperator = index; // индекс знака выражения
                index++; // переступаем через знак
                Node nodeOperator = null, rightNode = null;
                if (expr[index] != '(')
                {
                    rightNode = CreateChildNode(expr, ref index);
                }
                else
                {
                    rightNode = Bkt(expr, ref index);
                }
                switch (expr[exprOperator])
                {
                    case '+':
                        CreateIndependentNode('+', ref tempTop, ref nodeOperator, rightNode);
                        lastNode = rightNode;
                        Parsing(ref tempTop, lastNode, nodeOperator, expr, ref index);
                        break;
                    case '-':
                        CreateIndependentNode('-', ref tempTop, ref nodeOperator, rightNode);
                        lastNode = rightNode;
                        Parsing(ref tempTop, lastNode, nodeOperator, expr, ref index);
                        break;
                    case '*':
                        CreateDependentNode('*', ref tempTop, ref nodeOperator, rightNode, lastNode, ref penult);
                        lastNode = rightNode;
                        Parsing(ref tempTop, lastNode, nodeOperator, expr, ref index);
                        break;
                    case '/':
                        CreateDependentNode('/', ref tempTop, ref nodeOperator, rightNode, lastNode, ref penult);
                        lastNode = rightNode;
                        Parsing(ref tempTop, lastNode, nodeOperator, expr, ref index);
                        break;
                    case '^':
                        CreateDependentNode('^', ref tempTop, ref nodeOperator, rightNode, lastNode, ref penult);
                        lastNode = rightNode;
                        Parsing(ref tempTop, lastNode, nodeOperator, expr, ref index);
                        break;
                }
            }
        }
        private Node CreateChildNode(string expr, ref int index)
        {
            Node childNode = null;
            string funcName = GetFuncName(expr, ref index);
            if (funcName != "")
            {
                if (CheckFunc(funcName))
                {
                    index++; // перейти за 1ю скобку
                    childNode = ParsingFunc(funcName, expr, ref index);
                    index++; // перейти за 2ю скобку
                }
                else
                {
                    childNode = new Node(funcName, null, null);
                }
            }
            else
            {
                childNode = new Node(GetNumber(expr, ref index), null, null);
            }
            return childNode;
        }
        private void CreateDependentNode(object key, ref Node tempTop, ref Node nodeOperator, Node rightNode, Node lastNode, ref Node penult)
        {
            if (tempTop == lastNode)
            {
                nodeOperator = new Node(key, tempTop, rightNode);
                tempTop = nodeOperator;
            }
            else
            {
                nodeOperator = new Node(key, lastNode, rightNode);
                penult.right = nodeOperator;
            }
        }
        private void CreateIndependentNode(object key, ref Node tempTop, ref Node nodeOperator, Node rightNode)
        {
            nodeOperator = new Node(key, tempTop, rightNode);
            tempTop = nodeOperator;
        }
        private Node ParsingFunc(string nameFunc, string expr, ref int index)
        {
            Node tempFunc = new Node(nameFunc, null, null);
            Node rightFunc = CreateChildNode(expr, ref index);
            Node tempLastNode = rightFunc, penult = rightFunc;
            Parsing(ref rightFunc, tempLastNode, penult, expr, ref index);
            tempFunc.right = rightFunc;

            return tempFunc;
        }
        private Node Bkt(string expr, ref int index)
        {
            index++; // через скобку
            string funcName = GetFuncName(expr, ref index);
            Node tempTop = CreateChildNode(expr, ref index);
            Node tempLastNode = tempTop, penult = tempTop;
            Parsing(ref tempTop, tempLastNode, penult, expr, ref index);
            return tempTop;
        }
        private string GetFuncName(string expr, ref int index)
        {
            string tmp = "";
            while (index < expr.Length && Char.IsLetter(expr[index]))
            {
                tmp += expr[index++];
            }
            return tmp;
        }
        private string GetNumber(string expr, ref int index)
        {
            string tmp = "";
            int k;
            while (index < expr.Length && Int32.TryParse(expr[index].ToString(), out k))
            {
                tmp += expr[index++];
            }
            return tmp;
        }
        private bool CheckFunc(string func)
        {
            return
                func == "cos" ||
                func == "sin" ||
                func == "tg" ||
                func == "ctg" ||
                func == "acos" ||
                func == "asin" ||
                func == "atg" ||
                func == "actg" ||
                func == "ln"
                ;
        }
        private bool CheckOper(string key)
        {
            return
                key == "+" ||
                key == "-" ||
                key == "*" ||
                key == "/" ||
                key == "^"
            ;
        }
        public double GetValue(int value)
        {
            return Operation(Top, value);
        }
        private double Operation(Node q, int value)
        {
            if (q != null)
            {
                double key = 0;
                if (!CheckFunc(q.key.ToString()) && !CheckOper(q.key.ToString()) && !Double.TryParse(q.key.ToString(), out key))
                {
                    key = value;
                }
                else
                {
                    if (Double.TryParse(q.key.ToString(), out key))
                    { }
                }
                switch (q.key.ToString())
                {
                    case "+":
                        return Operation(q.left, value) + Operation(q.right, value);
                    case "-":
                        return Operation(q.left, value) - Operation(q.right, value);
                    case "*":
                        return Operation(q.left, value) * Operation(q.right, value);
                    case "/":
                        return Operation(q.left, value) / Operation(q.right, value);
                    case "%":
                        return Operation(q.left, value) % Operation(q.right, value);
                    case "^":
                        return Math.Pow(Operation(q.left, value), Operation(q.right, value));
                    default:
                        if (CheckFunc(q.key.ToString()))
                        {
                            return TrigGo(q.key.ToString(), q.right, value);
                        }
                        else return key;
                }
            }
            return 1;
        }
        private double TrigGo(string s, Node q, int value)
        {
            double y = 0;
            double x = Operation(q, value);
            switch (s)
            {
                case "cos":
                    return Math.Cos(x);
                case "sin":
                    return Math.Sin(x);
                case "tg":
                    return Math.Tan(x);
                case "ctg":
                    return 1 / Math.Tan(x);
                case "arccos":
                    return Math.Acos(x);
                case "arcsin":
                    return Math.Asin(x);
                case "arctg":
                    return Math.Atan(x);
                case "arcctg":
                    return 1 / Math.Atan(x);
                case "ln":
                    return Math.Log(x);
                default:
                    throw new Exception();
            }
            return 0;
        }
    }
}

//if (!Char.IsLetter(expr[index]))
//{
//    rightNode = new Node(GetNumber(expr, ref index), null, null);
//}
//else // если тригонометрическое выражение
//{
//    string trigName = GetFuncName(expr, ref index);
//    index++; // перейти за 1ю скобку
//    rightNode = ParsingFunc(trigName, expr, ref index);
//    index++; // перейти за 2ю скобку
//}