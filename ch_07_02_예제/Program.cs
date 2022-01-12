﻿using System;

namespace ch_07_02_예제
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";

        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Cat() // 종료자
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }

        class MainApp
        {

            static void Main(string[] args)
            {
                Cat kitty = new Cat("키티", " 하얀색");
                kitty.Meow();
                Console.WriteLine($"{kitty.Name} : {kitty.Color}");

                Cat nero = new Cat("네로", " 검은색");
                nero.Meow();
                Console.WriteLine($"{nero.Name} : {nero.Color}");
            }
        }
    }
}


//키티: 야옹
//키티 :  하얀색
//키티 : 야옹
//네로 :  검은색