using System;

namespace ch_03_07_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Console.Write(a); // 데이터 출력 후 줄을 바꾸지 않습니다. 
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            Console.WriteLine(); // 데이터 출력 후 줄을 바꿉니다.
        }
    }
}

//안녕하세요
