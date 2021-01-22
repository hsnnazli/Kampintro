using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakail = new Dictionary<int, string>();
            plakail.Add(06, "Ankara");
            plakail.Add(34, "İstanbul");

            foreach (var item in plakail)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
