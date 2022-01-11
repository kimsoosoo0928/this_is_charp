using System;

namespace ch_03_05_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);
            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);

            // float : 4바이트 (32비트)
            // double : 8바이트 (64비트)

        }
    }
}

//3.1415927
//3.141592653589793
