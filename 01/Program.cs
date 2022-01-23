using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5]; // 배열 생성 
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");

            
            
        }
    }
}
