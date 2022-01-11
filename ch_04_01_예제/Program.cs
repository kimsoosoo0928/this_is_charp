using System;

namespace ch_04_01_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");

            int c = b * 100;
            Console.WriteLine($"c : {c}");

            double d = c / 6.3; // 피연산자 중 한쪽이 부동 소수형이면 부동 소수형 버전의 연산자가 사용되며, 나머지 피연산자도 부동 소수형으로 형식 변환됩니다.

            Console.WriteLine($"22/7 ={22/7}({22%7})");
        }
    }
}

//a: 333
//b: 233
//c: 23300
//22 / 7 = 3(1)