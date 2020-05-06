using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork05._05
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> mylist = new MyList<string>();
            foreach (var n in mylist)
            {
                Console.WriteLine(n); 
            }
            MyDictionary<int, string> my = new MyDictionary<int, string>();
            my.Add(1, "2");
            Console.WriteLine(my[1]);
            MyDictionary<string, int> m = new MyDictionary<string,int>();
            m.Add("1", 1);
            int a = m["1"];
            Console.WriteLine(m["1"]);
            MyDictionary<int, Person> l = new MyDictionary<int, Person>();
            l.Add(1, new Person());
            l[1].name = "e";
            MyDictionary<int,string> dsa = new MyDictionary<int,string>();
            dsa.Add(1,"a");
            dsa.Add(22, "2");
            foreach (var keys in dsa.Keys)
            {
                Console.WriteLine(keys);
            }
            foreach (var values in dsa.Values)
            {
                Console.WriteLine(values);
            }
            Console.ReadKey();

            Dictionary<int, string> mydiction = new Dictionary<int, string>();
            foreach (var items in mydiction)
            {
                Console.WriteLine(items);
                Console.WriteLine(items.Key);
                Console.WriteLine(items.Value);
            }
        }
    }
    class Person
    {
        public string name { get; set; }
    }
}   
