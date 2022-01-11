using System;

namespace ch_03_28_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10진수 : {0:D}", 123);
            Console.WriteLine("10진수 : {0:D5}", 123);

            Console.WriteLine("16진수: 0x{0:X}, OxFF1234");
            Console.WriteLine("16진수: 0x{0:X8}, OxFF1234");

            // N : 숫자
            Console.WriteLine("숫자 : {0:N}", 123456789);
            Console.WriteLine("숫자 : {0:N0}", 123456789); // 자릿수 0은 소수점 이하를 제거함

            // F : 고정소수점
            Console.WriteLine("고정소수점: {0:F}",123.45);
            Console.WriteLine("고정소수점: {0:F5}", 123.456);

            // E : 공학용
            Console.WriteLine("공학: {0:E}", 123.456789);
          

        }
    }
}


//10진수: 123
//10진수: 00123
//16진수: 0x{ 0:X}, OxFF1234
//16진수: 0x{ 0:X8}, OxFF1234
//숫자 : 123,456,789.00
//숫자: 123,456,789
//고정소수점: 123.45
//고정소수점: 123.45600
//공학: 1.234568E+002
