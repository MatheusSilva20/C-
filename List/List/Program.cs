using System;
using System.Globalization;
using System.Collections.Generic;
namespace List{ 
    class Program{
        static void Main(string[] args){

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' : " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : " + s1);

            int pos1 = list.FindIndex(X => X[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos1);

            int pos2 = list.FindLastIndex(X => X[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos1);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("-------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            
        }

        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}
