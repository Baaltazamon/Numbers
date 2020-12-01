using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sip123
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers(3,5);
            num.Print();
            Numbers num2 = new Numbers(4, 7);
            num2.Print();
            Numbers num3 = new Numbers();
            num3 = num3.Division(num, num2);
            num3.Print();
            Console.ReadKey();
        }
    }
}
