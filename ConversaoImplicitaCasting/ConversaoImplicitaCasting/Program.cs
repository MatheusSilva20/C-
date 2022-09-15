using System;

namespace ConversaoImplicitaCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 4.5f;
            double b = 0;
            Console.WriteLine(b);//Conversao Implicita

            double c = 5.1;
            float d;
            d = (float)c;//Conversao Casting
            Console.WriteLine(d);

        }
    }
}
