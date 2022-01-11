using System;

namespace ch_04_06_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수"; // 10을 2로 나눈 나머지가 0이냐? true면 짝수, false면 홀수
            Console.WriteLine(result);
        }
    }
}

//짝수