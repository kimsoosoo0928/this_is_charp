using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine($"Greeting : {greeting}");

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine($"Greeting : {greeting}");

            string[] array3 = { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray3...");
            foreach (string greeting in array3)
                Console.WriteLine($"Greeting : {greeting}");
        }
    }
}
