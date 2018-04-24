using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAbstruct_2_Enum
{
    class Program
    {
        enum Job
        {
            STUDENT = 1,
            TEACHER,
            PROGROMMER
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("選擇職業: 1) Student 2) Teacher 3) Programmer ?");
                Job input = (Job)DataHelper.CheckInt(Console.ReadLine());

                BaseJob job = null;
                // Job myJob = Job.PROGROMMER;

                switch (input)
                {
                    case Job.STUDENT:
                        job = new Student();

                        break;
                    case Job.TEACHER:
                        job = new Teacher();

                        break;
                    case Job.PROGROMMER:
                        job = new Progrommer();

                        break;
                    default:
                        job = new NotExisted();
                        break;
                }
                job.DoWork();
            }
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
        }
    }
    public class Progrommer : BaseJob
    {
        public override void DoWork()
        {
            Console.WriteLine("Coding!");
        }
    }
    public class NotExisted : BaseJob
    {
        public override void DoWork()
        {
            Console.WriteLine("Not Existed!");
        }
    }

    public static class DataHelper
    {
        public static int CheckInt(string input)
        {
            int num;
            if (int.TryParse(input, out num))
            {
                return num;
            }
            return -1;
        }
    }
}
