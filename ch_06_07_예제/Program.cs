using System;

namespace ch_06_07_예제
{
    class Program // 메소드 오버로딩 : 코드를 일관성 있게 유지해줍니다.
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling int Plus(double, double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling int Plus(int, double)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1,2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
        
        }
    }
}


//Calling int Plus(int, int)...
//3
//Calling int Plus(int, int, int)...
//6
//Calling int Plus(double, double)...
//3.4
//Calling int Plus(int, double)...
//3.4