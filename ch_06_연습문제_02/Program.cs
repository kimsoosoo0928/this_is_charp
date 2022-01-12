using System;

namespace ch_06_연습문제_02
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, mean);

            Console.WriteLine("평균 : {0}",mean);

         
        }
        public static void Mean(
            double a, double b, double c,
            double d, double e, double result)
        {
            result = (a + b + c + d + e) / 5;
        }
    }
}
