using System;

namespace ch_05_09_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 }; // 배열, 여러 개의 데이터를 담을 수 있는 코드 요소

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}


//0
//1
//2
//3
//4