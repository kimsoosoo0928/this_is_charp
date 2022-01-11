using System;

namespace ch_06_02_예제
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n; // 프로그램의 흐름을 갑자기 호출자에게로 돌려놓는다.
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요");
                return; 
            }

            Console.WriteLine($"Name:{name}, Phone:{phone}");

        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)} ");

            PrintProfile("", "123-4567");
            PrintProfile("김현수", "010-7553-5128");
        }
    }
}


//10번째 피보나치 수 : 55
//이름을 입력해주세요
//Name:김현수, Phone: 010 - 7553 - 5128