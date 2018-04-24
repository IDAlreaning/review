using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet
{
    class Program
    {
        //建立 A 類別
        public class A
        {
            public string v;
            public string name;
            //A class被實例化時，會立即執行建構子內容，並且可以傳入參數
            //public string Show
            //{
            //    get { return name; }
            //    set
            //    {
            //        name = v;
            //        Console.WriteLine("I am " + value);
            //    }
            //}
            public int Show { get; set; }
        }


        static void Main(string[] args)
        {
            //實例化A類別
            A x = new A();

            x.v = "Brown";
            //x.Show = "Joe";
            Console.WriteLine(x.Show);

            Console.ReadKey();
        }
    }
}
