using System;

namespace ch_07_05_예제
{
    class Employee
    {
        private string Name;
        private string Position;

        public void Setname(string name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class MainApp
    { 

        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.Setname("pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()}{pooh.GetPosition()}");

            Employee tigger = new Employee();
            pooh.Setname("Tigger");
            pooh.SetPosition("Claenr");
            Console.WriteLine($"{tigger.GetName()}{tigger.GetPosition()}");

        }
    }
}
