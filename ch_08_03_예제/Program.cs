using System;

namespace ch_08_03_예제
{
    interface IRunnable // 인터페이스 선언
    {
        void Run(); // 인터페이스 메소드
    }

    interface IFlyable // 인터페이스 선언
    {
        void Fly(); // 인터페이스 메소드
    }

    class FlyingCar : IRunnable, IFlyable // 인터페이스 2개 상속 
    {
        public void Run() // 상속받은 인터페이스 구현 
        {
            Console.WriteLine("Run! Run!"); // 메서드 코드 구현 
        }

        public void Fly() // 상속받은 인터페이스 구현 
        { Console.WriteLine("Fly Fly"); // 메서드 코드 구현 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable; // ? 
            runnable.Run();

            IFlyable flyable = car as IFlyable; // ?
            flyable.Fly();
        }
    }
}
