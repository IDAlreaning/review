using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box box1 = new Box(1,1);
            //Box box2 = new Box(2,3);
            //Box box3 = new Box(2,3);

            Random random = new Random();
            List<Box> boxes = new List<Box>();
            for (int i = 0; i < 8; i++)
            {
                boxes.Add(new Box(random.Next(1, 100), random.Next(1, 100)));
            }
            //boxes.Sort();
            boxes.Sort(new Width());
            foreach (var item in boxes)
            {
                Console.WriteLine(item.width);
            }

            Console.WriteLine("=======");

            boxes.Sort(new Height());
            foreach (var item in boxes)
            {
                Console.WriteLine(item.height);
            }

            Console.WriteLine("=======");

            boxes.Sort(new Area());
            foreach (var item in boxes)
            {
                Console.WriteLine(item.Area);
            }
        }
    }

    public class Box/* : IComparable*/
    {
        public int width;
        public int height;

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area
        {
            get { return width * height; }
        }

        //public int CompareTo(object box)
        //{
        //    if (box is Box)
        //    {
        //        int otherArea = ((Box)box).Area;
        //        if (Area < otherArea)
        //        {
        //            return 1;
        //        }
        //        else if (Area == otherArea)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("Error!");
        //    }
        //}
    }

    public class Width : IComparer<Box>
    {
        public int Compare(Box a, Box b)
        {
            return a.width.CompareTo(b.width);
        }
    }

    public class Height : IComparer<Box>
    {
        public int Compare(Box a, Box b)
        {
            return a.height.CompareTo(b.height);
        }
    }
    public class Area : IComparer<Box>
    {
        public int Compare(Box a, Box b)
        {
            return a.Area.CompareTo(b.Area);
        }
    }
}
