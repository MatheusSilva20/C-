using System;

namespace OperadoresAtribuição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);//pega a variável e soma com o 10

            a *= 3; Console.WriteLine(a);//ele pega o resultado do a+=2 e faz a * 3 

            string s = "ABC";
            Console.WriteLine(s);// += funciona com letras tambem

            s += "DEF";
            Console.WriteLine(s);
        }
    }
}
