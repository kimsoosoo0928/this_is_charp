using System;

namespace ch_03_19
{
    class Program
    {
        enum DialogResult { yes, no, cancel, confirm, ok}

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.yes;

            Console.WriteLine(result == DialogResult.yes);
            Console.WriteLine(result == DialogResult.no);
            Console.WriteLine(result == DialogResult.cancel);
            Console.WriteLine(result == DialogResult.confirm);
            Console.WriteLine(result == DialogResult.ok);
        }
    }
}

//True
//False
//False
//False
//False
