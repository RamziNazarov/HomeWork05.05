using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HomeWork05._05
{
    class MyList<T>
    {
        static T[] myList = new T[0];
        public int Count { get { return myList.Length; } }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= myList.Length)
                    throw new IndexOutOfRangeException();
                return myList[index];
            }
        }
        public void Add(T element)
        {
            Array.Resize(ref myList, myList.Length + 1);
            myList[myList.Length - 1] = element;
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] == (dynamic)element)
                    return i;
            }
            return -1;
        }
        public IEnumerator GetEnumerator()
        {
            return (dynamic)myList.GetEnumerator();
        }
    }
}
