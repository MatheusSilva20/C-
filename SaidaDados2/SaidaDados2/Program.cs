using System;
using System.Globalization;

namespace SaidaDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome, idade, saldo);//Saída de Dados com PlaceHolders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");//Saída de Dados com Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");//Saída de Dados com Concatenação
        }
    }
}
