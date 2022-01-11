using System;

namespace ch_03_01_예제
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -5000_0000_0000; // 1바이트 8비트
            byte b = 40; // 1바이트 8비트 

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000; // 2바이트 16비트 
            ushort d = 60000; // 2바이트 16비트 

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; // 0이 7개 // 4바이트 32비트
            uint f = 3_0000_0000; // 0이 8개 // 4바이트 32비트 

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // 0이 11개 //8바이트 64비트
            ulong h = 200_0000_0000_0000; // 0이 18개 //8바이트 64비트

            Console.WriteLine($"g={g},h={h}");
        }
    }
}

//a = -10, b = 40
//c = -30000, d = 60000
//e = -10000000, f = 300000000
//g = -500000000000,h = 200000000000000
