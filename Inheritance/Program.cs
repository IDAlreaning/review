using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird("111","222");
            Dog dog = new Dog("333","444");
            Console.WriteLine($"skill:{bird.skill}, attribute:{bird.attribute}");
            Console.WriteLine($"skill:{dog.skill}, attribute:{dog.attribute}");
        }
    }
    class Animal
    {
        public string skill;
        public string attribute;

        public Animal(string skill, string attribute)
        {
            this.skill = skill;
            this.attribute = attribute;
        }

        public virtual void GetSkill()
        {

        }
    }

    class Bird : Animal
    {
        public Bird(string skill, string attribute) : base(skill, attribute)
        {

        }
        public override void GetSkill() { }
    }
    class Dog : Animal
    {
        public Dog(string skill, string attribute) : base(skill, attribute)
        {

        }
        public override void GetSkill() { }
    }


}
