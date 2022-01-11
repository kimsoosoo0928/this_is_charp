using System;

namespace ch_03_02_예제
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 240; // 10진수 리터럴
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000; // 2진수 리터럴
            Console.WriteLine($"b={b}");

            byte c = 0XF0; // 16진수 리터럴

            uint d = 0x1234_abcd; // 16진수 리터럴;
            Console.WriteLine($"d={d}");
        }
    }
}
//a = -10, b = 40
//c = -30000, d = 60000
//e = -10000000, f = 300000000
//g = -500000000000,h = 200000000000000
