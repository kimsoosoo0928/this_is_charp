using System;

namespace ch_03_20_예제
{
    class Program
    {
        enum DialogResult { yes = 10, no, cancel, confirm = 50, ok }
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.yes); //10
            Console.WriteLine((int)DialogResult.no); //11
            Console.WriteLine((int)DialogResult.cancel); //12
            Console.WriteLine((int)DialogResult.confirm); //50
            Console.WriteLine((int)DialogResult.ok); //51
            
        }
    }
}


//10
//11
//12
//50
//51