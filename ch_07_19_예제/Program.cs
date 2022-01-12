using System;

namespace ch_07_19_예제
{
   readonly struct RGBColor // 변경 불가능 구조체 
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b) // 생성자
        {
            R = r; // 초기화
            G = g;
            B = b;

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            RGBColor Red = new RGBColor(255, 0, 0); // 새로운 객체
            Red.G = 100; // 컴파일 에러
        }
    }
}
