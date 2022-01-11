using System;

namespace ch_03_10_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            // object는 모든 데이터 형식의 조상

            object a = 123;
            object b = 3.1411231512412412m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}

//123
//3.1411231512412412
//True
//안녕하세요.