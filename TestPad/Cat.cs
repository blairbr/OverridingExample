using System;
using System.Collections.Generic;
using System.Text;

namespace TestPad
{
    public class Cat : Animal
    {
        private int happiness { get; set; }
        private int hunger { get; set; }

        private void Meow() {
            Console.WriteLine("Meoowwww");
        }

        public override void Eat() {
            happiness++;
            Console.WriteLine("happiness " + happiness);
         
            Meow();
        }
        
    }

}
