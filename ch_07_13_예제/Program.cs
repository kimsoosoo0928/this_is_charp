using System;

namespace ch_07_13_예제
{
    class Base
    {
        public virtual void SealMe()
        {

        }
        
        class Derived : Base
        {
            public sealed override void SealMe() // 상속 봉인 
            {
                
            }
        }
        class WantToOverride : Derived
        {
            public override void SealMe()
            {

            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                
            }
        }
    }
}
