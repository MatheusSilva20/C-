﻿using System;
using System.Globalization;

namespace ExSaidaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}",produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, código {1} e genero: {2}", idade, codigo, genero);
            Console.WriteLine("Medida com oito decimais {0:F8}", medida);
            Console.WriteLine("Arredondado tres casas decimais : {0:F3}", medida);
            Console.WriteLine("Separador decimal Invariant Culture " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}