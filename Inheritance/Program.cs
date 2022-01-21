using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * 
             * Creatively display the class member values 
             */

            Bird chicken = new Bird();
            chicken.Name = "Nuggets";
            chicken.CanFly = false;
            chicken.Age = 4;
            chicken.Feathers = true;

            chicken.PrintBird();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();





            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile crocodile = new Reptile();
            crocodile.BackBones = true;
            crocodile.ColdBlooded = true;
            crocodile.Age = 70;
            crocodile.CanSwim = true;

            crocodile.PrintCrocodile();
        }
    }
}
