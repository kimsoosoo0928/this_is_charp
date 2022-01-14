using System;

namespace ch_09_11_예제
{
    abstract class Product // 추상 클래스
    {
        private static int serial = 0;
        public string SerialID // 구현을 가진 프로퍼티 
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate // 구현이 없는 프로퍼티 
        {
            get;
            set;
        }
            
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate // 추상 프로퍼티 재정의
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Product product_1 = new MyProduct()
            { ProductDate = new DateTime(2018, 1, 10) };

            Console.WriteLine("Product:{0}, Product Date: {1}",
            product_1.SerialID,
            product_1.ProductDate);

            Product product_2 = new MyProduct()
            { ProductDate = new DateTime(2018, 2, 3) };

            Console.WriteLine("Product:{0},Product Date:{1}",
                product_2.SerialID,
                product_2.ProductDate);

        }
    }
}
