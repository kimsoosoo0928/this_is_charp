using System;

namespace ch_05_12_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;

            }
        }
    }
}
//계속할까요 ? (예 / 아니오) : 예
//계속할까요 ? (예 / 아니오) : 예
//계속할까요 ? (예 / 아니오) : 아니
//계속할까요 ? (예 / 아니오) : 아니오