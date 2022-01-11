using System;

namespace ch_03_18_예제
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK } // enum 열거형식명 : 기반자료형 {상수1, 상수2, 상수3......}
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}

//0
//1
//2
//3
//4