using System;
using System.Collections;

namespace ch_04_07_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?가 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 이제 더 이상 null이 아닙니다.
            a?.Add("야구");
            a?.Add("축구");
            Console.WriteLine($"Count: {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");
        }
    }
}

//Count:


//Count: 2
//야구
//축구