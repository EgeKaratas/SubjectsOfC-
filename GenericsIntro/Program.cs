﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ege");
            isimler.Add("Cantug");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
