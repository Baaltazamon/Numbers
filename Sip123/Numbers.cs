using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sip123
{
    class Numbers
    {
        int numerator;
        int denominator;
        public Numbers(int Num, int Den)
        {
            numerator = Num;
            denominator = Den;
        }
        public Numbers()
        {

        }
        public void Print()
        {
            if (numerator < denominator)
            {
                Numbers cc = Reduction(numerator, denominator);
                Console.WriteLine($"{cc.numerator}/{cc.denominator}");

            }
                
            else if (numerator == denominator)
                Console.WriteLine($"1");
            else
            {
                int c = numerator / denominator;
                int d = numerator - (denominator * c);
                Numbers cc = Reduction(d, denominator);
                Console.WriteLine($"{c}({cc.numerator}/{cc.denominator})");
            }
        }
        public Numbers Reduction(int Num, int Den)
        {
            bool t = false;
            int g = 0;
            for (int i = denominator; i != 0; i--)
            {
                if (denominator % i == 0 && Num % i == 0)
                {
                    t = true;
                    g = i;
                    break;
                }

            }
            if (t)
            {
                int a = Num / g;
                int b = denominator / g;
                return new Numbers(a, b);

            }
            return new Numbers(Num, Den);
        }
        public Numbers Multiply(Numbers n1, Numbers n2)
        {
            return new Numbers(n1.numerator * n2.numerator, n1.denominator * n2.denominator);
        }

        public Numbers Additional(Numbers n1, Numbers n2)
        {
            int x1;
            int x2;
            int y1;
            int y2;
            if (n1.denominator > n2.denominator)
            {
                x1 = n1.denominator;
                x2 = n2.denominator;
                y1 = n1.numerator;
                y2 = n2.numerator;
            }
            else
            {
                x1 = n2.denominator;
                x2 = n1.denominator;
                y1 = n2.numerator;
                y2 = n1.numerator;
            }

            if (x1%x2 == 0)
            {
                int mnoj = x1 / x2;
                x2 *= mnoj;
                y2 *= mnoj;

            }
            else
            {
                int z = x1*x2;
                for (int i = x1; i < x1*x2; i++)
                {
                    if (i % x1 == 0 && i % x2 == 0)
                    {
                        z = i;
                        Console.WriteLine(z);
                        break;
                    }
                }
                y1 = y1 * (z / x1);
                x1 = z;
                y2 = y2 * (z / x2);
                x2 = z;
            }

            return new Numbers(y1 + y2, x1);
        }
        public Numbers DeAdditional(Numbers n1, Numbers n2)
        {
            int x1;
            int x2;
            int y1;
            int y2;
            bool g;
            if (n1.denominator > n2.denominator)
            {
                x1 = n1.denominator;
                x2 = n2.denominator;
                y1 = n1.numerator;
                y2 = n2.numerator;
                g = true;
            }
            else
            {
                x1 = n2.denominator;
                x2 = n1.denominator;
                y1 = n2.numerator;
                y2 = n1.numerator;
                g = false;
            }

            if (x1 % x2 == 0)
            {
                int mnoj = x1 / x2;
                x2 *= mnoj;
                y2 *= mnoj;

            }
            else
            {
                int z = x1 * x2;
                for (int i = x1; i < x1 * x2; i++)
                {
                    if (i % x1 == 0 && i % x2 == 0)
                    {
                        z = i;
                        Console.WriteLine(z);
                        break;
                    }
                }
                y1 = y1 * (z / x1);
                x1 = z;
                y2 = y2 * (z / x2);
                x2 = z;
            }
            if (g)
            {
                return new Numbers(y1 - y2, x1);
            }
            else
            {
                return new Numbers(y2 - y1, x1);
            }
            
        }

        public Numbers Division(Numbers n1, Numbers n2)
        {
            return new Numbers(n1.numerator * n2.denominator, n1.denominator * n2.numerator);
        }
    }
}
