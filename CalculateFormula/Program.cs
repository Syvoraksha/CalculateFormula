using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Calculations calc = new Calculations();
            menu.printFormula();
            menu.InputA();
            double a = menu.ReturnA(Console.ReadLine());
            menu.InputB();
            double b = menu.ReturnB(Console.ReadLine());
            menu.InputC();
            double c = menu.ReturnC(Console.ReadLine());
            menu.InputD();
            double d = menu.ReturnD(Console.ReadLine());
            menu.InputE();
            double e = menu.ReturnE(Console.ReadLine());
            menu.InputF();
            double f = menu.ReturnF(Console.ReadLine());

            Console.WriteLine(calc.ReturnResult(a, b, c, d, e, f));

            Console.ReadLine();
        }
    }
}
