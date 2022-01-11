using System;

namespace ch_03_04_예제
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; // uint의 최대값

            Console.WriteLine(a);

            a = a + 1; // 오버플로 : 변수에도 데이터 형식의 크기를 넘어선 값을 담으면 넘친다.

            Console.WriteLine(a);

        }
    }
}

//4294967295
//0
