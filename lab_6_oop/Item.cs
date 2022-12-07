using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6_oop
{
        class Item 
        {
            int key;
            Item Next; 

            public Item() 
            {
                key = 0;
                Next = null;
            }

            public Item(int key) 
            {
                this.key = key;
                Next = null;
            }

            public Item(int key, Item Next) 
            {
                this.key = key;
                this.Next = Next;
            }

            public void AddNext(Item N) 
            {
                Next = N;
            }

            public void Print() 
            {
                String S = "";
                S = Convert.ToString(key) + " ";
                Console.WriteLine(S);
            }

            public Item GetNext() 
            {
                return Next;
            }

            public int GetKey() 
            {
                return key;
            }

        }
    }

