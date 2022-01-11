using System;

namespace ch_03_16_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString(); // 정수 -> 문자열
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString(); // 실수 -> 문자열
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e); // 문자열 -> 정수
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g); // 문자열 -> 실수 
            Console.WriteLine(h);
        }
    }
}

//123
//3.14
//123456
//1.2345