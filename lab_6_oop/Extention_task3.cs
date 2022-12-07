using System;
using System.Collections.Generic;
using System.Text;
using lab_6_oop;

namespace lab6_3
{
    static class Extention_task3
    {
        public static int[] GetArray(this MyList<int> mylist )
        {
            int[] list = new int[3];
            list[0] = 1;
            list[1] = 2;
            list[2] = 3;
            foreach (int x in list)
            {
                Console.Write(x.ToString() + " ");
            }
            return list;
        }
   }
}

