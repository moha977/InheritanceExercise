using System;
using System.Collections.Generic;
using System.Text;
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
namespace Inheritance
{
    public class Reptile : Animal 
    {
        public Reptile()
        {

        }
        public bool CanSwim { get; set; }
        public bool BackBones { get; set; }
        public bool ColdBlooded { get; set; }
        public string HumanFriendly { get; set; }

        public void PrintCrocodile()
        {
            Console.WriteLine($"Do Crocodiles have backbones? {BackBones} \n" +
                $"Are Crocodiles cold blooded? {ColdBlooded}\n" +
                $"How long crocodiles live for? up to {Age} Years\n" +
                $"Can crocodiles swim? {CanSwim}");
        }
    }
}
