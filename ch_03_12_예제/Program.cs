using System;

namespace ch_03_12_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127; // 1바이트
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // sbyte의 최대값 127보다 1 큰 수
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // 오버플로 발생 
            Console.WriteLine(y);
        }
    }
}

//127
//127
//128
//- 128
