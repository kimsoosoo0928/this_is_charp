using System;

namespace ch_04_04_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3>4 : {3>4}");
            Console.WriteLine($"3>=4 : {3 >= 4}");
            Console.WriteLine($"3<4 : {3 < 4}");
            Console.WriteLine($"3<=4 : {3 <= 4}");
            Console.WriteLine($"3==4 : {3 == 4}");
            Console.WriteLine($"3!=4 : {3 != 4}");
        }
    }
}

//3 > 4 : False
//3 >= 4 : False
//3 < 4 : True
//3 <= 4 : True
//3 == 4 : False
//3 != 4 : True
