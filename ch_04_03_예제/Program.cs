using System;

namespace ch_04_03_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "123" + "456"; // 문자열 결합 연산자 
            Console.WriteLine(result);

            result = "Hello" + " " + "World!";
            Console.WriteLine(result);
        }
    }
}


//123456
//Hello World!