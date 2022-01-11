using System;

namespace ch_03_22_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type:{0},Value:{1}", a.GetType(), a);

            var b = 3.141234;
            Console.WriteLine("Type:{0},Value:{1}", b.GetType(), b);

            var c = "hello, soo!";
            Console.WriteLine("Type:{0},Value:{1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 }; // 배열도 var로 선언할 수 있다.
            Console.WriteLine("Type:{0},Value", a.GetType());
            foreach (var e in d)
                Console.Write("{0} ", e);
            Console.WriteLine();
        }
    }
}

//Type: System.Int32,Value: 20
//Type: System.Double,Value: 3.141234
//Type: System.String,Value: hello, soo!
//Type: System.Int32,Value
//10 20 30