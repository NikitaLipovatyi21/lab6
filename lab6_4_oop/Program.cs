using System;
using lab6_4_oop;

namespace lab6_4_oop
{
    class Program
    {
        static void Main(string[] args)
        {
                MyClass.FactoryMethod<int>();
                MyClass.FactoryMethod<string>();
                Console.ReadKey();
        }
    }
}
