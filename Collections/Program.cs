﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Kemal");
            isimler.Add("Ali");
            isimler.Add("Mahmut");

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("İlker");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
        }
    }
}
