using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStatic
{
    class Program
    {
        struct MyStruct
        {
            public static int x = 100;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyStruct.x);
            Console.WriteLine(MyStruct.x = 50);
            Console.WriteLine(MyStruct.x = 100);

            MyStruct mystruct;
            // Console.WriteLine(mystruct.x = 30);
            Console.WriteLine(mystruct.y =200);

        }
    }
}
