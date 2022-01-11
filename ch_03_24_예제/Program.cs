using System;
using static System.Console;

namespace ch_03_24_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            //IndexOf() 문자열 위치 검색
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));
            // LastIndexOf() 문자열의 위치를 뒤에서부터 검색
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));
            //StartWith() 지정된 문자열로 시작하는지를 평가
            WriteLine("StartIndexOf 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartIndexOf 'o' : {0}", greeting.StartsWith('o'));
            //EndWith() 지정된 문자열로 끝나는지를 평가
            WriteLine("EndIndexOf 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndIndexOf 'o' : {0}", greeting.EndsWith('o'));
            // Contains() 지정된 문자열을 포함하는지를 평가
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));
            // Replace 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환
            WriteLine("Replaced 'Morning' with 'Evening':{0}", greeting.Replace("Morning", "Evening"));
        }
    }
}


//Good Morning

//IndexOf 'Good' : 0
//IndexOf 'o' : 1
//LastIndexOf 'Good' : 0
//LastIndexOf 'o' : 6
//StartIndexOf 'Good' : True
//StartIndexOf 'o' : False
//EndIndexOf 'Good' : False
//EndIndexOf 'o' : False
//Contains 'Evening' : False
//Contains 'Morning' : True
//Replaced 'Morning' with 'Evening':Good Evening
