using System;

namespace ch_07_01_예제
{
    class Cat // 클래스
    {
        public string Name; // 필드
        public string Color;

        public void Meow() // 메서드
        {
            Console.WriteLine($"{Name} : 야옹");
        }
        static void Main(string[] args)
        {
            Cat kitty = new Cat(); // 객체 = 생성자
            kitty.Color = "하얀색";
            kitty.Name = "키티";

            kitty.Meow();
            Console.WriteLine($"{kitty.Name}: {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            
                
        }
    }
}

//키티: 야옹
//키티: 하얀색
//네로 : 야옹
//네로 : 검은색
