using System;
using lab6_3;





namespace lab_6_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть елементiв");
            int kol = Int32.Parse(Console.ReadLine());
            int[] Mas = new int[kol];
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("введiть " + (i + 1) + " елемент списку");
                string str = Console.ReadLine();
                Mas[i] = Convert.ToInt32(str);
            }
            MyList<int> mylist = new MyList<int>(Mas);
            mylist.ShowList();

            Console.WriteLine("Знайти елемент ...");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            mylist.Index(c).Print();

            Console.WriteLine("Додати элемент в кiнець списку...");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            mylist.Add(c);
            mylist.ShowList();
            Console.WriteLine(mylist.GetArray());
            Console.ReadKey();
        }
    } 
}
