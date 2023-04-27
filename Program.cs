using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, FstDigit, ScdDigit, ThdDigit, a;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            FstDigit = num/100;
            ScdDigit = num/10%10;
            ThdDigit = num%10;
            if (FstDigit < ScdDigit)
            {
                a = ScdDigit;
                ScdDigit = FstDigit;
                FstDigit = a;
            }
            if (ScdDigit < ThdDigit)
            {
                a = ThdDigit;
                ThdDigit = ScdDigit;
                ScdDigit = a;
            }
            if (FstDigit < ScdDigit)
            {
                a = ScdDigit;
                ScdDigit = FstDigit;
                FstDigit = a;
            }
            Console.WriteLine("Right number is: {0}", FstDigit*100 + ScdDigit*10 + ThdDigit);
            Console.ReadKey(false);
        }
    }
}
