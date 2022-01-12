using System;

namespace ch_06_10_예제
{
    class Program
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-7553-5128");
        }
    }
}


//Name: 중근, Phone:
//Name: 관순, Phone: 010 - 123 - 1234
//Name: 봉길, Phone:
//Name: 동주, Phone: 010 - 7553 - 5128