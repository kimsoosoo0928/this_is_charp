using System;

namespace ch_03_03_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255; // byte 형식 255는 1111 111
            sbyte b = (sbyte)a; // 변수를 sbyte 형식으로 변환하는 연산자

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
