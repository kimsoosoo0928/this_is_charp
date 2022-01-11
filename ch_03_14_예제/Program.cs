using System;

namespace ch_03_14_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a; // 언더플로우 X
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x; // 언더플로우 O
            Console.WriteLine(y);
        }
    }
}

//500
//500
//- 30
//4294967266
