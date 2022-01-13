using System;

namespace ch_08_02_예제
{

    interface ILogger // 인터페이스 선언 
    {
        void WriteLog(string message); // 인터페이스 메서드 
    }
    
    interface IFormattableLogger : ILogger // ILogger 상속 
    {
        void WriteLog(string format, params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger // IFormattableLogger 상속
    {
        public void WriteLog(string message) // 상속받은 메서드 
        {
            Console.WriteLine("{0}{1}",DateTime.Now.ToLocalTime(),message);
        }

        public void WriteLog(string format, params Object[] args) // 상속받은 메서드2
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0}{1}",DateTime.Now.ToLocalTime(),message);
        }
      
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat");
            logger.WriteLog("{0}+{1}={2}", 1, 1, 2);
        }
    }
}

//2022 - 01 - 13 오전 10:21:56The world is not flat
//2022-01-13 오전 10:21:561 + 1 = 2
