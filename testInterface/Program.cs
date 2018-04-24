using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterface
{

    interface IFly
    {
        void fly();
    }

    interface ISwim
    {
        void swim();
    }

    public class Myname
    {
        public string Name { get; set; }
    }

    public class FlyFish : Myname, IFly, ISwim//正確的繼承寫法為類別在前，介面在後
    {
        public FlyFish(string name)
        {
            this.Name = name;
        }

        public void fly()
        {
            Console.WriteLine(Name + "~我會飛");
        }

        public void swim()
        {
            Console.WriteLine("我是飛魚~我會游泳");
        }
    }

    class Program////主程式從這邊開始
    {
        static void Main(string[] args)
        {
            FlyFish flyFish = new FlyFish("飛魚一號");
            flyFish.fly();
            flyFish.swim();

            Console.ReadKey();
        }
    }
}
