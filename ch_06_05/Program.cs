using System;

namespace ch_06_05
{
    class Program
    {

        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }

        static void Main(string[] args)
        {
            Program carrot = new Program();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

        }
    }
}


//Price: 100
//Ref Local Price :100
//Normal Local Price :100
//Price: 200
//Ref Local Price : 200
//Normal Local Price : 100