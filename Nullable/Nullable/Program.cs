﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable{
     class Program {
        static void Main(string[] args){

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if(x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X is null");

            //if(y.HasValue)
            //    Console.WriteLine(y.Value);

            //else
            //    Console.WriteLine("Y is null");
        }
    }
}
