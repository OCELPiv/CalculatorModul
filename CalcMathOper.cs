using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public static class CalcMathOper
    {
        private static Random random = new Random();
        public static double Abs(double x)
        {
            return Math.Abs(x);
        }

        public static double Div(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Деление на 0");
            return x / y;
        }

        public static int Mod(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Деление на 0");
            return x % y;
        }

        public static (int, int) Rand(int min = -100, int max = 100)
        {
            int x = random.Next(min, max);
            int y = random.Next(min, max);
            return (x,y);
        }

        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static string Clr()
        {
            return string.Empty;
        }
    }
}
