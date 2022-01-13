using System;

namespace ch_08_04_예제
{
    interface ILogger
    {
        void WriteLog(string message); // 메소드 1

        void WriteError(string error) // 새로운 메소드 추가 // 메소드 2 

        {
            WriteLog($"Error : {error}");

        }
    }

    class ConsoleLogger : ILogger // 인터페이스 상속
    {
        public void WriteLog(string message) // 인터페이스 상속 
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}"); 
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger(); // 객체 생성
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger(); // 객체 생성
            clogger.WriteLog("System Up"); // OK
            // clogger.WriteError("System Fail"); // 컴파일 에러 
        }
    }

}
