using System;

namespace ch_07_14_예제
{
    class Configuration
    {
        private readonly int min;
        private readonly int max; // readonly를 이용해서 읽기 전용 필드를 선언합니다.

        public Configuration(int v1, int v2)
        {
            min = v1; // 읽기 전용 필드는 생성자 안에서만 초기화 가능합니다. 
            min = v2;
        }

        public void ChangeMax(int newMax)
        {
            max = newMax; // 생성자가 아닌 다른곳에서 값을 수정하려 하면 컴파일 에러가 발생합니다 ! 
        }
    }

    class MainApp {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    } 

}
