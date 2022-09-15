using System;
using System.Globalization;
namespace SaidaDados { 
    class Program{
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("Com quebra de linha");//O WriteLine efetua a quebra de linha
            Console.Write("Sem quebra de linha");// Quando somente Write ele não quebra a linha
            Console.WriteLine("Com quebra de linha");
            Console.WriteLine("-------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));//To.String limita o numero a ser mostrado na saida de dados sendo F2 dois numeros após a vírgula e arredondado
            Console.WriteLine(saldo.ToString("F4"));//To.String limita o numero a ser mostrado na saida de dados sendo F4 quatro numeros após a vírgula e arredondado
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));//InvariantCulture é um separador de decimais
        }   

    }
}