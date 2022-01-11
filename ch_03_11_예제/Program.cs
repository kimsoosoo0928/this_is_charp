using System;

namespace ch_03_11_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b; // b에 담긴 값을 언박싱해서 스택에 저장 

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            object y = x; // x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y; // y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}

//123
//123
//123
//3.1414213
//3.1414213
//3.1414213

// object 형식은 참조 형식이기 깨문에 힙에 데이터를 할당한다. int 형식이나 double 형식은 값 형식이기 때문에 스택에 데이터를 할당한다. 
