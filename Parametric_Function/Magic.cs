using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Magic
{
    public double MagicPow(double a, double b)//Степень
    {
        for (int i = 0; i < b - 1; i++)
            a *= a;
        return a;
    }
    public double MagicSqrt(double x, int num)
    {
        double eps = 0.0000000001, x1 = x, x2;
        double a;
        int i;
        if (num == 0)
            return 1;
        do
        {
            x2 = x1;
            a = 1;
            for (i = 1; i < num; i++)
                a *= x1;
            x1 = ((num - 1) * x2 + x / a) / num;
        } while (MagicAbs(x2 - x1) >= eps);
        return x1;
    }
    public double MagicFract(double x)
    {
        double i = 0;
        if (x > 0)
        {
            while (i + 1 < x)
                i++;
            return (x - i);
        }
        else
            if (x < 0)
            {
                while (i - 1 > x)
                    i--;
                return (-1 * (x - i));
            }
            else return 0;
    }
    public double MagicSin(double fi)//Sin
    {
        //Через ряд Тейлора : x - x^3 / 3! + x^5 / 5! - x^7 / 7! +... = SuperSum(((-1)^i * x^(2i+1)) / (2i + 1)!)
        double result = 0;
        double term = 1, y = -1;
        int index = 1;
        bool ok = true;
        for (int i = 0; i < 30; i++)
        {
            while (index <= 2 * i + 1)
                term *= fi / index++;
            y *= -1;
            if (!ok)
                result += y * term;
            else
            {
                result = fi;
                ok = false;
            }
        }
        return result;
    }
    public double MagicCos(double fi)//Cos
    {
        //Через ряд Тейлора : 1 - x^2 / 2! + x^4 / 4! - x^6 / 6! +... = SuperSum(((-1)^i * x^(2i + 1)) / (2i)!)
        double result = 1;
        double term = 1, y = 1;
        int index = 1;
        for (int i = 1; i < 30; i++)
        {
            while (index <= 2 * i)
                term *= fi / index++;
            y *= -1;
            result += y * term;
        }
        return result;
    }
    public double MagicTg(double fi)//Tg
    {
        return MagicSin(fi) / MagicCos(fi);
    }
    public double MagicCtg(double fi)//Ctg
    {
        return MagicCos(fi) / MagicSin(fi);
    }
    public double MagicLog(double x)//Логарифм
    {
        //Через ряд Тейлора : ln((1+x) / (1-x)) = 2(x + x^3 / 3 + x^5 / 5 + x^7 / 7 +...)
        x--;
        if (MagicAbs(x) <= 1)
        {
            double result = 0;
            double y = -1;
            double k = 1;
            for (int i = 1; i < 30; i++)
            {
                k *= x;
                y *= -1;
                result += y * (k / i);
            }
            return result;
        }
        else
        {
            return 1;
        }
    }
    public double MagicMin(double a, double b)//Min
    {
        return (a > b) ? b : a;
    }
    public double MagicMax(double a, double b)//Max
    {
        return (a > b) ? a : b;
    }
    public double MagicInc(double x)//+1
    {
        return ++x;
    }
    public double MagicDec(double x)//-1
    {
        return --x;
    }
    public double MagicSucc(double x)//+1
    {
        return ++x;
    }
    public double MagicPred(double x)//-1
    {
        return --x;
    }
    public double MagicAbs(double x)//Модуль
    {
        return (x > 0) ? x : x * -1;
    }
    public double MagicAsin(double x)//Arcsin
    {
        //Через ряд Тейлора : x + SuperSum( ( (2n - 1)!! / (2n)!! )  * x^(2n+1) / 2n + 1) = 
        double result = x;
        double term = 1;
        int index = 1;
        double a = 1;
        for (double i = 1; i < 30; i++)
        {
            a *= (2 * i - 1) / (2 * i);
            while (index <= 2 * i + 1)
            {
                term *= x;
                index++;
            }
            index--;
            term /= index;
            result += term * a;
        }
        return result;
    }
    public double MagicAcos(double x)//Arccos
    {
        return Math.PI / 2 - MagicAsin(x);
    }
    public double MagicArctg(double fi)//Arctg
    {
        double result = 0;
        double term = 1, y = -1;
        int index = 1;
        bool ok = true;
        for (int i = 0; i < 30; i++)
        {
            while (index <= 2 * i + 1)
                term *= fi / index++;
            y *= -1;
            if (!ok)
                result += y * term;
            else
            {
                result = fi;
                ok = false;
            }
        }
        return result;
    }
    public double MagicArcctg(double x)//Arctg
    {
        return 1;
    }
}