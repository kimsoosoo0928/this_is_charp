using System;

namespace ch_04_02_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); // a를 출력시키고, 증가
            Console.WriteLine(++a); // a를 증감시키고, 출력

            Console.WriteLine(a--); // a를 출력시키고, 감소
            Console.WriteLine(--a); // a를 감소시키고, 출력
        }
    }
}

//10
//12
//12
//10
