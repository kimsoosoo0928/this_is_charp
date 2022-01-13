using System;
using System.IO;

namespace ch_08_01_예제
{

    interface ILogger // 인터페이스 작성
    {
        void WriteLog(string message); // 인터페이스 메소드
    }

    class ConsoleLogger : ILogger // 인터페이스 상속 
    {
        public void WriteLog(string message) // 상속받은 인터페이스 메서드 구현 
        {
            Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(), message); 
        }
    }

    class FileLogger : ILogger // 인터페이스 상속 
    {
        private StreamWriter writer; // 필드 

        public FileLogger(string path) // 메소드
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message) // 인터페이스 메소드 상속 
        {
            writer.WriteLine("{0}{1}", DateTime.Now.ToShortDateString(), message);
        }

    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger; // 필드 = 매개변수 
        }
    
    
    public void start()
    {
        while (true)
        {
            Console.Write("온도를 입력해주세요.: ");
            string temperature = Console.ReadLine();
            if (temperature == "")
                break;

            logger.WriteLog("현재 온도: " + temperature);
            
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
                ClimateMonitor monitor = new ClimateMonitor(
                    new FileLogger("MyLog.txt"));

                monitor.start();

                   
        }
    }
}
