using System;
using System.Collections.Generic;
using System.Text;

namespace TestPad
{
    public class Person 
    {
        public void FeedCat(Cat cat) {
            Console.WriteLine("Cat is fed");
            cat.Eat();
        }

        public void FeedAnimal(Animal animal) {
            Console.WriteLine("Animal is fed");
            animal.Eat();
        }
       

    }
}
