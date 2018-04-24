using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProtected
{
    class Program
    {
        static void Main(string[] args)
        {
            Cmoney cmoney = new Cmoney();

        }
    }

    class BaseStudent
    {
        protected int no;
        protected string name;
        public void output()
        {
            Console.WriteLine($"No: {no}, Name: {name}");
        }
    }

    class Cmoney : BaseStudent
    {
        public void cmoney(int no, string name)
        {
            this.no = no;
            this.name = name;
        }
    }
}
