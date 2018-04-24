using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1,"IDA");
            Console.WriteLine(student.ToString());
        }
    }

    class Student
    {
        public int Id;
        public string Name;
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format($"ID: {Id}, NAME: {Name}");
        }
    }
}
