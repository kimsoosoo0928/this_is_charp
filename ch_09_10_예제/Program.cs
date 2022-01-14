using System;

namespace ch_09_10_예제
{
    interface INamedValue
    {
        string Name // 자동 구현 프로퍼티처럼 구현이 없지만, C# 컴파일러는 인터페이스의 프로퍼티에 대해서는 자동으로 구현해주지 않습니다. 인터페이스는 어떤 구현도 가지지 않기 때문입니다.
        {
            get;
            set;        
        }

        string Value
        {
            get;
            set;
        }
    }

    class NamedValue : INamedValue // 인터페이스 상속 
    { 
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }        
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "박상현" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "177cm" };

            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name}:{name.Value}");
            Console.WriteLine($"{height.Name}:{height.Value}");
            Console.WriteLine($"{weight.Name}:{weight.Value}");

        }

        
    }
}

//이름: 박상현
//키:177cm
//몸무게:90kg