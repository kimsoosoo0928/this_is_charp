using System;

namespace ch_07_20_예제
{

    struct ACSetting
    {
        public double currentInCelsius; // 현재온도
        public double target; // 희망 온도 
        
        public readonly double GetFahareheit()
        { //화씨 계산 결과를 타겟에 저장
            target = currentInCelsius * 1.8 + 32;
            return target; // target 반환
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahareheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
