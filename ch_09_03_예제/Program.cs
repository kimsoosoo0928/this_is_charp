using System;

namespace ch_09_03_예제
{
    class BirthdatInfo
    {
        public string Name // 프로퍼티
        {
            get;
            set;
        }

        public DateTime Birthday // 프로퍼티 
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

        class MainApp
        {
        static void Main(string[] args)
            {
                BirthdatInfo birth = new BirthdatInfo() 
                {
                    Name = "서현", // 프로퍼티를 이용한 초기화 
                    Birthday = new DateTime(1991, 6, 28) // 프로퍼티를 이용한 초기화
                };

                Console.WriteLine($"Name : {birth.Name}");
                Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
                Console.WriteLine($"Age : {birth.Age}");
            }
        }

}

