using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            object obj = i;
            Console.WriteLine($"預設: {i}\n");

            if (obj is int)
            {
                Console.WriteLine($"Object: {obj}");
            }
            i = 200;
            Console.WriteLine($"修改: {i}");
            Console.WriteLine($"Object: {obj}");

            int j = (int)obj;
            Console.WriteLine($"拆箱: {j}");

        }
    }
}
