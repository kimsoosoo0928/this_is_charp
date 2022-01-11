using System;

namespace ch_03_25_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToLower() : '{0}", "ABC".ToLower());
            Console.WriteLine("ToUpper() : '{0}", "abc".ToLower());

            Console.WriteLine("Insert() : '{0}'", "Happy Friday".Insert(5, "Sunny"));
            Console.WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));

            Console.WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            Console.WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            Console.WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
        }
    }
}

//ToLower() : 'abc
//ToUpper() : 'abc
//Insert() : 'HappySunny Friday'
//Remove() : 'I Love You'
//Trim() : 'No Spaces'
//TrimStart() : 'No Spaces '
//TrimEnd() : ' No Spaces'