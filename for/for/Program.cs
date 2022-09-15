using System;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Quantos números inteiros vc vai digitar? ");
            int n1 = int.Parse(Console.ReadLine());


            int soma = 0;
            for (int i = 1; i <= n1; i++) {
                Console.Write("Valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
