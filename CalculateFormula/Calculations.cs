using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFormula
{
    public class Calculations
    {
        public string ReturnResult(double a, double b, double c, double d, double e, double f)
        {
            double result = a + b * c / Math.Pow((d - e), f);
            return (Math.Round((result), 5)).ToString();
        }
    }
}
