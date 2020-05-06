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
            MyDictionary<int, string> my = new MyDictionary<int, string>();
            my.Add(1, "2");
            my[1] = "22";
            Console.WriteLine(my[1]);
            MyDictionary<string, int> m = new MyDictionary<string,int>();
            m.Add("1", 1);
            m["1"] = 2123;
            Console.WriteLine(m["1"]);
            int a = m["1"];
            Console.WriteLine(m["1"]);
            MyDictionary<int, Person> l = new MyDictionary<int, Person>();
            l.Add(1, new Person());
            l.Values[0].name = "asdf";
            l[1].name = "e";
            MyDictionary<int,string> dsa = new MyDictionary<int,string>();
            dsa.Add(1,"a");
            dsa.Add(23212, "2");
            foreach (var keys in dsa.Keys)
            {
                Console.WriteLine(keys);
            }
            foreach (var values in dsa.Values)
            {
                Console.WriteLine(values);
            }
            //foreach (var sg in dsa)
            //{
                
            //    Console.WriteLine(sg);
            //}

            //MyDictionary<int, Person> per = new MyDictionary<int, Person>();
            //per.Add(1, new Person() { name = "qwe" });
            //foreach (var tt in per)
            //{
            //    Console.WriteLine(tt);
            //}
            //foreach (var st in per.Values)
            //{
            //    Console.WriteLine(st);
            //}
            //int asddd = per.Keys[0];
            //Person pro = per.Values[0];
            //Console.WriteLine(asddd);
            //Console.WriteLine(pro);
            Console.ReadKey();

            Dictionary<int, string> mydiction = new Dictionary<int, string>();
            mydiction.Add(1, "1");
            mydiction.Add(2, "2");
            foreach (var items in mydiction)
            {
                Console.WriteLine(items);
                Console.WriteLine(items.Key);
                Console.WriteLine(items.Value);
            }
            Console.Read();
        }
    }
    class Person
    {
        public string name { get; set; }
    }
}   
