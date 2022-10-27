using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            /*int m = n / 1000;
            int c = (n - (m) * 1000) / 100;
            int x = (n - (m) * 1000 - c * 100) / 10;
            int i = n - (m) * 1000 - c * 100 - x * 10;
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(i);*/
            Console.WriteLine(ConvertToRoman(n));
            Console.ReadLine();



        }
        public static string ConvertToRoman(int n)
        {
            if (n == 0)
            {
                return "Nullus";
            }
            if (n > 3999)
            {
                return "Please enter an integer less than or equal to 3999";
            }
            if (n < 0)
                return "Please enter a positive integer";
            else
            {
                string[] m = { "", "M", "MM", "MMM" };
                string[] c = {"", "C", "CC","CCC", "CD", "D",
                            "DC", "DCC", "DCCC", "CM"};
                string[] x = {"", "X", "XX", "XXX", "XL", "L",
                            "LX", "LXX", "LXXX", "XC"};
                string[] i = {"", "I", "II", "III", "IV", "V",
                            "VI", "VII", "VIII", "IX"};

                int mInt = n / 1000;
                int cInt = (n - (mInt) * 1000) / 100;
                int xInt = (n - (mInt) * 1000 - cInt * 100) / 10;
                int iInt = n - (mInt) * 1000 - cInt * 100 - xInt * 10;
                var thousands = m[mInt];
                var hundereds = c[cInt];
                var tens = x[xInt];
                var ones = i[iInt];

                var ans = thousands + hundereds + tens + ones;

                return ans;
            }
        }

    }
}
