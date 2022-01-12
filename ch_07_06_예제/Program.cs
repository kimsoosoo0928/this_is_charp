using System;

namespace ch_07_06_예제
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("Myclass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b},{c})");
        }
        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
        class MainApp
        {


            static void Main(string[] args)
            {
                MyClass a = new MyClass();
                a.PrintFields();
                Console.WriteLine();

                MyClass b = new MyClass(1);
                b.PrintFields();
                Console.WriteLine();

                MyClass c = new MyClass(10, 20);
                c.PrintFields();
            }
        }
    }
}


//Myclass()
//a: 5425, b: 0, c: 0

//Myclass()
//MyClass(1)
//a: 5425, b: 1, c: 0

//Myclass()
//MyClass(10)
//MyClass(10, 20)
//a: 5425, b: 10, c: 20