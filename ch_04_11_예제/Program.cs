using System;

namespace ch_04_11_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}"); // num은 null이므로 0이 출력된다.

            num = 99;
            Console.WriteLine($"{num ?? 0}"); // num은 null이 아니므로 99가 출력된다

            string str = null;
            Console.WriteLine($"{str ?? "Default"}"); // str은 null이므로 Defalut가 출력된다.

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}"); // str은 bull이 아니므로 Specific이 출력된다.
               
        }
    }
}

//0
//99
//Default
//Specific
