using System;

namespace OperadoresComparativos{
    class Program{
        static void Main(string[] args){
            int n1 = 10;
            bool c1 = n1 < 10;
            bool c2 = n1 < 20;
            bool c3 = n1 > 10;
            bool c4 = n1 > 20;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("-------------------------------");
            bool c5 = n1 <= 10;
            bool c6 = n1 >= 10;
            bool c7 = n1 == 10;
            bool c8 = n1 != 10;
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);              
            Console.WriteLine(c8);
        }
    }
}
