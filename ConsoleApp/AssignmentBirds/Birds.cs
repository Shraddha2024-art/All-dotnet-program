using System;

namespace BirdInheritanceExample
{
    // Base class
    class Birds
    {
        public double Weight { get; set; }
        public string Color { get; set; }
       
        public Birds(string,color,float wt)
        {
            Color= color;
            Weight=wt;
        }

        public virtual void Voice()
        {
            Console.WriteLine("This bird makes a sound - chiivvvv chiivvv");
        }
    }
}
