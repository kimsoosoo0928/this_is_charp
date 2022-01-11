using System;

namespace ch_04_08_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing <<...");

            int a = 1;
            Console.WriteLine("a      : {0:D5}(0x{0:X8})",a);
            Console.WriteLine("a << 1 : {0:D5}(0x{0:X8})", a << 1);
            Console.WriteLine("a << 2 : {0:D5}(0x{0:X8})", a << 2);
            Console.WriteLine("a << 5 : {0:D5}(0x{0:X8})", a << 5);

            Console.WriteLine("\nTesting >> ...");

            int b = 255;
            Console.WriteLine("b      : {0:D5}(0x{0:X8})", b);
            Console.WriteLine("b << 1 : {0:D5}(0x{0:X8})", b << 1);
            Console.WriteLine("b << 2 : {0:D5}(0x{0:X8})", b << 2);
            Console.WriteLine("b << 5 : {0:D5}(0x{0:X8})", b << 5);

            Console.WriteLine("\nTesting >> 2 ...");

            int c = -255;
            Console.WriteLine("c      : {0:D5}(0x{0:X8})", c);
            Console.WriteLine("c << 1 : {0:D5}(0x{0:X8})", c >> 1);
            Console.WriteLine("c << 2 : {0:D5}(0x{0:X8})", c >> 2);
            Console.WriteLine("c << 5 : {0:D5}(0x{0:X8})", c >> 5);
        }
    }
}

//Testing << ...
//a: 00001(0x00000001)
//a << 1 : 00002(0x00000002)
//a << 2 : 00004(0x00000004)
//a << 5 : 00032(0x00000020)

//Testing >> ...
//b: 00255(0x000000FF)
//b << 1 : 00510(0x000001FE)
//b << 2 : 01020(0x000003FC)
//b << 5 : 08160(0x00001FE0)

//Testing >> 2...
//c: -00255(0xFFFFFF01)
//c << 1 : -00128(0xFFFFFF80)
//c << 2 : -00064(0xFFFFFFC0)
//c << 5 : -00008(0xFFFFFFF8)

