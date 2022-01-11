using System;
using System.Globalization;

namespace ch_03_29_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            Console.WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24시간 형식: {0:yyyy-MM-dd hh:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)",ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd  HH:mm:ss (dddd)", ciKo));
            Console.WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyyy-MM-dd  HH:mm:ss (dddd)", ciEn));
            Console.WriteLine(dt.ToString(ciEn));

        }
    }
}

//12시간 형식: 2018 - 11 - 03 오후 11:18:22(토)
//24시간 형식: 2018 - 11 - 03 11:18:22(토요일)

//2018 - 11 - 03 오후 11:18:22(토)
//2018 - 11 - 03  23:18:22(토요일)
//2018 - 11 - 03 오후 11:18:22

//2018 - 11 - 03 PM 11:18:22(Sat)
//2018 - 11 - 03  23:18:22(Saturday)
//11 / 3 / 2018 11:18:22 PM