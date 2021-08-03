using System;

namespace Static_method_and_prop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stavka.MinSum = 100;

            Stavka stavka1 = new Stavka(120, 10);
            Console.WriteLine(Stavka.getSum(120, 10, 3));

            Stavka stavka2 = new Stavka(300, 20);

            Console.WriteLine(Stavka.Counter);
        }
    }
}
