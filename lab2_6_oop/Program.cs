using System;
using System.Collections.Generic;

namespace lab2_6_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(4, "Tom");
            dictionary.Add(10, "Robert");
            dictionary.Add(15, "Mary");
            dictionary.PrintDictionary();

            Console.WriteLine(dictionary.GetLengthK());
            Console.ReadKey();

        }
    }
}
