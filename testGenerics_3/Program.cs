using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGenerics_3
{
    public class Book
    {
    }
    public class Food
    {
    }
    public class EnglishBook : Book
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mylist<Book> mylist = new Mylist<Book>();
            Mylist<EnglishBook> mylist2 = new Mylist<EnglishBook>();

        }
    }
    public class Mylist<T> where T : Book
    {

    }
}
