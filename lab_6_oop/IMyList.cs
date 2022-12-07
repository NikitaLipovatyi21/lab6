using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6_oop
{
    interface IMyList
    {
         Item Add(int key);
        void ShowList();

         Item Index(int key);
    }
}
