﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDateTime{
     class Program{
        static void Main(string[] args){

            DateTime d = DateTime.Now;
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);  
            DateTime d4 = d.AddDays(7);

            DateTime d5 = new DateTime(2000, 10, 18);
            DateTime d6 = new DateTime(2000, 10, 15);
            TimeSpan t = d6.Subtract(d5);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(t);














            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("9) Minute: " + d.Minute);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);
        }
    }
}
