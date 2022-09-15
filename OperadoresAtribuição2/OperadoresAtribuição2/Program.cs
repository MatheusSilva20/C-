using System;

namespace OperadoresAtribuição2
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a++;//incremento entao seria a variável +1
            int b = 10;
            b--;//incremento entao seria a variável -1
            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 10;
            int d = ++c;//primeiro ele incrementa e depois ele pega o valor da variável
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
