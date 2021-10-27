using System;

namespace Line_Comparision_Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Computation Program");

            UC_1 length = new UC_1();
            length.CalculateLengthOfLine();

            UC_2 equal = new UC_2();
            equal.EqualityofLines();

            UC_3 comparison = new UC_3();
            comparison.ComparisonOfLines();

            UC_4 uc = new UC_4();
            uc.ComparisonOfLines();

        }
    }
}
