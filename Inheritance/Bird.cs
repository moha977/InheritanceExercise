using System;
using System.Collections.Generic;
using System.Text;
// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
        public bool CanFly { get; set; }    
        public bool Feathers { get; set; }  
        public bool Wings { get; set; }
        public bool beak { get; set; }

        public void PrintBird()
        {
            Console.WriteLine($"Chickens usually live for {Age} months.\n " +
                $"Do chickens fly? {CanFly}\n" +
                $"Do chicken have feathers? {Feathers}\n" +
                $"Best way to eat a chicken is {Name}.");

        }

    }
}
