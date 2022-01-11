using System;

namespace ch_03_15_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a; // 0.9 -> 0
            Console.WriteLine(b); 

            float c = 1.1f;
            int d = (int)c; // 1.1 -> 1
            Console.WriteLine(d);
        }
    }
}

//0
//1

