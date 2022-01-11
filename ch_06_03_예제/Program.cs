using System;

namespace ch_06_03_예제
{
    class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
                b = a;
                a = temp;
        }
        
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x:{x}, y:{y}");

            Swap(x, y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}


//x: 3, y: 4
//x: 3, y: 4