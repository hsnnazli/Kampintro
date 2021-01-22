using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakail = new MyDictionary<int, string>();
        
            plakail.Add(06, "Ankara");
            plakail.Add(34, "İstanbul");


        }
    }
}
