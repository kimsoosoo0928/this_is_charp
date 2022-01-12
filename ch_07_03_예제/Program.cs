using System;

namespace ch_07_03_예제
{
    class Global
    {
        public static int Count = 0; // 프로그램 전체에 걸쳐 공유해야하는 변수
        class ClassA
        {
            public ClassA() // 글로벌의 카운트를 ++하는 메소드
            {
                Global.Count++;
            }
        }

        class ClassB
        {
            public ClassB() // 글로벌의 카운트를 ++하는 메소드
            {
                Global.Count++;
            }
        }
        class MainApp
        {
            static void Main()
            {
                Console.WriteLine($"Global.Count : {Global.Count}");

                new ClassA(); //1
                new ClassA(); //2
                new ClassB(); //3 
                new ClassB(); //4

                Console.WriteLine($"Global.Count : {Global.Count}");
            
                
            }
        }
    
    }
}

//Global.Count : 0
//Global.Count : 4
