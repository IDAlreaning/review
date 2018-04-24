using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAbstructClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseJob student = new Student();
            BaseJob teacher = new Teacher();
            student.DoWork();
            teacher.DoWork();
        }
    }

    public abstract class BaseJob
    {
        public abstract void DoWork();
    }
    public class Student : BaseJob
    {
        public override void DoWork()
        {
            Console.WriteLine("Reading!");
        }
    }
    public class Teacher : BaseJob
    {
        public override void DoWork()
        {
            Console.WriteLine("Teaching!");
            // throw new NotImplementedException();
        }
    }
}
