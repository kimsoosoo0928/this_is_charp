using System;

namespace ch_03_13_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a); // float

            double b = (double)a; // float -> double
            Console.WriteLine("b : {0}", b); // 안전하게 10진수로 복원
            Console.WriteLine("69.6875 == b : {0}",69.6875 == b); // 그러므로 참 

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);
            double y = (double)x;
            Console.WriteLine("y : {0}", y);

            Console.WriteLine("0.1 == y : {0}", 0.1 ==y);
        }
    }
}

//a: 69.6875
//b: 69.6875
//69.6875 == b : True
//x : 0.1
//y: 0.10000000149011612
//0.1 == y : False