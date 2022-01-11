using System;

namespace ch_05_06_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                Console.WriteLine("b) i : {0}", i--); // 여기에서 i는 이미 0이지만 이 코드는 한 차례 실행됩니다.

            }
            while (i > 0);
        }
    }
}


//a) i: 10
//a) i: 9
//a) i: 8
//a) i: 7
//a) i: 6
//a) i: 5
//a) i: 4
//a) i: 3
//a) i: 2
//a) i: 1
//b) i: 0