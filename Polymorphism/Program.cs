using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cmoney cmoney = new Cmoney();
            cmoney.Print();

        }
    }

    public class BaseStudent
    {
        public virtual void Print()
        {
            Console.WriteLine("hi");
        }
    }


    public class Cmoney : BaseStudent
    {
        public override void Print()
        {
            Console.WriteLine("hello");
        }
    }

    //public abstract class BaseStudent
    //{
    //    public abstract void Print();
    //}


    //public class Cmoney : BaseStudent
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("hello");
    //    }
    //}
}
