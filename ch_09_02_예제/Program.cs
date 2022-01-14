using System;

namespace ch_09_02_예제
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown"; // 자동구현 프로퍼티, 초기화 
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get // 읽기 전용 프로퍼티
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo Birth = new BirthdayInfo(); // 생성자 인스턴스 생성 
            Console.WriteLine($"Name : {Birth.Name}");
            Console.WriteLine($"Birthday : {Birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {Birth.Age}");

            Birth.Name = "서현";
            Birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {Birth.Name}");
            Console.WriteLine($"Birthday : {Birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {Birth.Age}");

        }
    }
       
 }

