using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFormula
{
    public class Menu
    {
        public void printFormula()
        {
            Console.WriteLine("a+b*c/" + "(" + "d-e" + ")" + "^f");
        }

        public void InputA()
        {
            Console.Write("Input a:");
        }
        public double ReturnA(string numberA)
        {
            return Convert.ToDouble(numberA);
        }

        public void InputB()
        {
            Console.Write("Input b:");
        }
        public double ReturnB(string numberB)
        {
            return Convert.ToDouble(numberB);
        }

        public void InputC()
        {
            Console.Write("Input c:");
        }
        public double ReturnC(string numberC)
        {
            return Convert.ToDouble(numberC);
        }

        public void InputD()
        {
            Console.Write("Input d:");
        }
        public double ReturnD(string numberD)
        {
            return Convert.ToDouble(numberD);
        }

        public void InputE()
        {
            Console.Write("Input e:");
        }
        public double ReturnE(string numberE)
        {
            return Convert.ToDouble(numberE);
        }

        public void InputF()
        {
            Console.Write("Input f:");
        }
        public double ReturnF(string numberF)
        {
            return Convert.ToDouble(numberF);
        }
    }
}
