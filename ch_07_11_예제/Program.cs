using System;

namespace ch_07_11_예제
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }
    
    class IronMan : ArmorSuite // ArmorSuite 상속
    {
        public override void Initialize() 
        {
            base.Initialize(); // 상속
            Console.WriteLine("Repulsor Rays Armed"); // 자신만의 무기 1
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed"); // 자신만의 무기 2
            Console.WriteLine("Micro-Rocket Launcher Armed"); // 자신만의 무기 3
        }
    }

    class MainApp
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorSuite = new ArmorSuite(); // new 연산자 새 유형의 인스턴스를 생성한다.
            armorSuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}

//Creating ArmorSuite...
//Armored

//Creating IronMan...
//Armored
//Repulsor Rays Armed

//Creating WarMachine...
//Armored
//Repulsor Rays Armed
//Micro-Rocket Launcher Armed
