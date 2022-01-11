using System;

namespace ch_04_05_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing && ..."); // and
            Console.WriteLine($"1 > 0 && 4 < 5 :{1>0 && 4<5}");
            Console.WriteLine($"1 > 0 && 4 < 5 :{1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 :{1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 :{1 == 0 && 4 < 5}");

            Console.WriteLine("\nTesting || ..."); // or
            Console.WriteLine("Testing || ...");
            Console.WriteLine($"1 > 0 || 4 < 5 :{1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 < 5 :{1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 :{1 == 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 :{1 == 0 || 4 < 5}");

            Console.WriteLine("\nTesting ! ..."); // !
            Console.WriteLine($"!True : {!true}");
            Console.WriteLine($"!False : {!false}");
        }
    }
}


//1 == 0 && 4 < 5 :False
//1 == 0 && 4 < 5 :False

//Testing || ...
//Testing || ...
//1 > 0 || 4 < 5 :True
//1 > 0 || 4 < 5 :True
//1 == 0 || 4 < 5 :False
//1 == 0 || 4 < 5 :True

//Testing ! ...
//!True : False
//!False: True
