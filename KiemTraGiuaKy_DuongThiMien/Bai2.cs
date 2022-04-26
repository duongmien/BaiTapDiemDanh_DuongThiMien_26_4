using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTraGiuaKy_DuongThiMien
{
    abstract class Animal
    {
        public abstract void eat();
        public abstract void makeSound();
    }
    class Bird : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating ");
        }

        public void fly()
        {
            Console.WriteLine("Flying");
        }

        public override void makeSound()
        {
            Console.WriteLine("Sounding");

        }
    }
    class Cat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Cat");

        }
        public void run()
        {
            Console.WriteLine("Running");
        }

        public override void makeSound()
        {
            Console.WriteLine("Sounding Cat");
        }
    }
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Cat");
            Cat cat = new Cat();
            cat.eat();
            cat.run();
            cat.makeSound();
            Console.WriteLine("This is Bird");
            Bird bird = new Bird();
            bird.eat();
            bird.fly();
            bird.makeSound();
        }
    }
}
