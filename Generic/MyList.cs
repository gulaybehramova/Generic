using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class MyList <T>
    {
        T[] list;
        public MyList()
        {
            list = new T[0];
        }
        public void Add(T value)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = value;
        }
        public void ShowList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
