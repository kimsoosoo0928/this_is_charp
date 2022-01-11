using System;

namespace ch_05_05_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            
            while (i>0) // 반복문 i>0일 동안 작동
            {
                Console.WriteLine($"i : {i--}"); // 감소연산자
            }
        }
    }
}


//i: 10
//i: 9
//i: 8
//i: 7
//i: 6
//i: 5
//i: 4
//i: 3
//i: 2
//i: 1
