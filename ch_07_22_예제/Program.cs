using System;

namespace ch_07_22_예제
{
    class Program
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만 
                ("학생", _) => 0.1, // 학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만 
                ("일반", _) => 0.05, // 일반 & 18세 이상 
            };
        }
        
        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);

            Console.WriteLine($"alice : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob : {GetDiscountRate(bob)}");
            Console.WriteLine($"dave : {GetDiscountRate(dave)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
        }
    }
}

//alice: 0.2
//bob: 0.1
//dave: 0.05
//charlie: 0.1
