using System;

namespace ch_09_07_예제
{

    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} ->{To,-10} : ${Amount}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = tr1 with { To = "Charlie" }; // tr1의 모든 상태를 복사한 다음, To 프로퍼티 값만 "Charlie"로 수정
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 }; // tr2의 모든 상태를 복사한 다음, From, To 프로퍼티 값만 수정
            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);

        }
    }
}


//Alice->Bob        : $100
//Alice->Charlie    : $100
//Dave->Charlie    : $30