using System;

namespace ch_03_연습문제_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int w  = int.Parse(width);
            int h = int.Parse(height);

            int area = w*h;

            Console.WriteLine($"사각형의 넓이는 : {area}");
        }
    }
}

//사각형의 너비를 입력하세요.
//30
//사각형의 높이를 입력하세요.
//40
//사각형의 넓이는 : 1200
