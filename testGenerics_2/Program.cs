using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGenerics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> list = new Mylist<string>();
            list.Add("AAA");
            list.Add("BBB");
            list.Add("CCC");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list.array[i]);
            }
        }
    }

    public class Mylist<T>
    {
        public T[] array = new T[0];

        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }
    }
}
