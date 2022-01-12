using System;

namespace ch_07_12_예제
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod");
        }
    }

    class Derived : Base
    {
        public new void MyMethod() // 메소드 숨기기 
        {
            Console.WriteLine("Derived.MyMethod()"); 
        }
    }
        class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived deriveObj = new Derived();
            deriveObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}


//Base.MyMethod
//Derived.MyMethod()
//Base.MyMethod