using System;

namespace ch_06_연습문제_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}",a,b,resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB); // 오버로드가 필요한 메소드입니다.

            Console.WriteLine("{0} + {1} = {2}",x, y,resultB);
        }
        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
        public static void Plus(double e, double f, out double g)
        {
            g = e + f;
        }

    }
}

//3 + 4 = 7
//2.4 + 3.1 = 5.5
