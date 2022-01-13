using System;

namespace ch_08_05_예제
{
    abstract class AbstractBase{ // 추상 클래스 
        
        protected void PrivateMethodA() 
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA(); // 추상 메서드 
    
    }

    class Derived : AbstractBase // 추상 클래스 상속 
    {
        public override void AbstractMethodA() // 추상 메소드 오버라이드 
        {
            throw new NotImplementedException();
            {
                Console.WriteLine("Derived.AbstractMethodA()");
                PrivateMethodA();
           
            }
        }
    }
}
