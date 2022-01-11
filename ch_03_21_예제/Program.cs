using System;

namespace ch_03_21_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null; // 데이터형식? 변수이름;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}


//False
//False
//True
//True
//3