using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        // This method finds the day or returns -1
        private int GetDay(string testDay)
        {

            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == testDay)
                {
                    return j;
                }
            }

            throw new ArgumentOutOfRangeException(testDay, "testDay must be in the form \"Sun\", \"Mon\", etc");
        }

        // The get accessor returns an integer for a given string
        public int this[string day]
        {
            get
            {
                return (GetDay(day));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayCollection week = new DayCollection();
            Console.WriteLine(week["Fri"]);
            //結果會顯示5，即"Fri"在物件內的陣列索引
            // Raises ArgumentOutOfRangeException
            Console.WriteLine(week["Made-up Day"]);

        }

    }
}
