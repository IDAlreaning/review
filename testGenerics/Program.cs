using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintData printData = new PrintData();
            printData.print(2);
            printData.print("1");
            printData.print(true);
        }


    }

    public class PrintData
    {
        public void print<T>(T x)
        {
            Console.WriteLine($"{x.GetType().Name} : {x}");
        }
    }
}
