using System;

namespace ch_03_26_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            Console.WriteLine(greeting.Substring(0, 5)); // 0~5 추출
            Console.WriteLine(greeting.Substring(5)); // 5이후로 추출
            Console.WriteLine();

            string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None); // 공백을 기준으로 단어 분리
            Console.WriteLine(("Word Count : ", arr.Length));
            
            foreach (string element in arr)
                Console.WriteLine("{0}", element); // arr 배열안에 스트링 요소를 하나씩 꺼내서 출력한다.

            
        }
    }
}


//Good
//morning.

//(Word Count : , 2)
//Good
//morning.