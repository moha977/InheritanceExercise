using System;
using System.Collections.Generic;
using System.Text;
// Create a class Animal
// give this class 4 members that all Animals have in common
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {

        }
        public string Name { get; set; } 
         public int Age { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }
    }
}
