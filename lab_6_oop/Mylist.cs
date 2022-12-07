using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace lab_6_oop
{
    class MyList<T> : IMyList
    {
        Item first;

        public MyList()
        {
            first = null;
        }

        public MyList(int[] mylist)
        {
            first = new Item(mylist[0], null);
            Item T, N;
            T = first;
            for (int i = 1; i < mylist.Length; i++)
            {
                N = new Item(mylist[i], null);
                T.AddNext(N);
                T = N;
            }
        }

        public void ShowList()
        {
            string S = "";
            Item N;
            N = first;
            while (N != null)
            {

                S = S + N.GetKey() + " "; N = N.GetNext();
            }

            Console.WriteLine(S);

        }

        public Item Index(int key) 
        {
            Item N;
            N = first;
            while ((N != null) && (N.GetKey() != key))
                N = N.GetNext();
            return N;
        }

        public Item Add(int key) 
        {
            Item End, N = new Item(key, null);
            End = first;
            while (End.GetNext() != null)
                End = End.GetNext();
            End.AddNext(N);
            return End;
        }

    }
}
