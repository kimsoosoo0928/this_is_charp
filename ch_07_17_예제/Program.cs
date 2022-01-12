using System;
using myExtension;

namespace MyExtension
{
    public static class IntegerExtension
        public static int Square(this int myInt)
{
    return myInt * myInt;
}

public static int Power(this int myInt, int exponent)
{ int result = myInt;
    for (int i = 1; i < exponent; i++)
        result = result * myInt;

    return result;
}
}


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
        }
    }
}
