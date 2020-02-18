using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPad
{
    class Program
    {
        static void Main(string[] args)
        {

            Person blair = new Person();
            Cat sputnik = new Cat();
            Animal animal = new Animal();

            Console.WriteLine("Now feeding cat.");
            blair.FeedCat(sputnik);
            Console.WriteLine("Now feeding Sputnik as an animal.");
            blair.FeedAnimal(sputnik);
            Console.WriteLine("Now feeding Animal as an animal");
            blair.FeedAnimal(animal);
        }
    }
}
