using System;

namespace ch_03_23_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
            Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("a type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("b type:{0}, value:{1}", d.GetType().ToString(), d);
        }
    }
}

//a type:System.Int32, value: 123
//b type:System.Int32, value: 456
//a type:System.String, value: abc
// b type: System.String, value: def
