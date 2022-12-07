using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_6_oop
{
    internal class MyDictionary<TKey,TValue>
    {
        TKey[] keylist = new TKey[0];
        TValue[] valuelist = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            TKey[] newkeylist = new TKey[GetLengthK() + 1];
            TValue[] newvaluelist = new TValue[GetLengthV() + 1];

            keylist.CopyTo(newkeylist, 0);
            valuelist.CopyTo(newvaluelist, 0);

            newkeylist[GetLengthK()] = key;
            newvaluelist[GetLengthV()] = value;

            keylist = newkeylist;
            valuelist = newvaluelist;

        }

        public TKey GetValueK(int index)
        {
            return keylist[index];
        }

        public TValue GetValueV(int index)
        {
            return valuelist[index];
        }

        public int GetLengthK()
        {
            return keylist.Length;
        }

        public int GetLengthV()
        {
            return valuelist.Length;
        }

        public void PrintDictionary()
        {
            for(int i =0; i < GetLengthK(); i++)
            {
                Console.WriteLine((i + 1) + ". " + keylist[i] + " : " + valuelist[i]);
            }
        }

    }
}
