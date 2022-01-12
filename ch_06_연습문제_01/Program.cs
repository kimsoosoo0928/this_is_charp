using System;

namespace ch_06_연습문제_01
{
    class Program
    {
        static double Square(double arg)
        {
            double result = arg * arg;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}",Square(arg);
        }
    }
}
