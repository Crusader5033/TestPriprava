using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("C");
            list.Add("B");
            list.Add("A");



            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            list.Sort();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine();


            LinkedList<int> linked = new LinkedList<int>();
            linked.AddFirst(5);
            linked.AddFirst(6);
            linked.AddFirst(4);
            foreach (int i in linked)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();


            HashSet<string> hash = new HashSet<string>();
            hash.Add("k");
            hash.Add("l");
            hash.Add("i");
            foreach (string s in hash)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine();


            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("a", 1);
            dic.Add("a¨b", 31);
            dic.Add("c", 12);

            foreach(KeyValuePair<string,int> pair in dic)
            {
                Console.WriteLine(pair.Key);
            }












        }
    }
}
