using System;

namespace BirdInheritanceExample
{
    // Derived class 1
    class Sparrow : Bird
    {
        public string type;
        public Sparrow(string type,string color,float wt)
        {
            Console.WriteLine("The sparrow is flying.");
        }
    }

    // Derived class 2
    class Parrot : Bird
    {
        public void Talk()
        {
            Console.WriteLine("The parrot is talking.");
        }
    }

    // Derived class 3
    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("The penguin is swimming.");
        }
    }
}
