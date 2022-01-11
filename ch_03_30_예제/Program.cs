using System;

namespace ch_03_30_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "김현수";
            int age = 30;
            Console.WriteLine($"{name, -10},{age:D3}");

            name = "송지현";
            age = 30;
            Console.WriteLine($"{name},{age,-10:D3}");

            name = "지현수";
                age = 30;
            Console.WriteLine($"{name},{(age>20 ? "성인" : "미성년자")}");


        }
    }
}


//김현수       ,030
//송지현,030
//지현수,성인