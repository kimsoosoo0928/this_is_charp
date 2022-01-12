using System;

namespace ch_07_18_예제
{
    struct Point3D // 구조체
    {
        public int X;
        public int Y;
        public int Z;

       public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString() // ToString() 메소드를 오버라이딩
        {
            return string.Format($"{X},{Y},{Z}");
        }

    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1; // 구조체는 인스턴스 생성시 new 연산자 필요없음 
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300); // 물론 생성자를 이용한 인스턴스 생성도 가능 
            Point3D p3d3 = p3d2;
            p3d3.Z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}
