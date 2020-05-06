using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HomeWork05._05
{
    class MyDictionary<TKey,TValue>
    {
        List<TKey> keys = new List<TKey>();
        List<TValue> values = new List<TValue>();
        public List<TKey> Keys { get { return keys; } }
        public List<TValue> Values { get { return values; } }
        public int Count { get { return keys.Count; } }
        public TValue this[TKey index]
        {
            get 
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i] == (dynamic)index)
                        return values[i];
                }
                throw new IndexOutOfRangeException(); 
            }
        }
        public void Add(TKey key,TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }
        public IEnumerator GetEnumerator()
        {
            IEnumerator a = keys.GetEnumerator();
            //a += values.GetEnumerator();
            return keys.GetEnumerator();
        }
    }
}
