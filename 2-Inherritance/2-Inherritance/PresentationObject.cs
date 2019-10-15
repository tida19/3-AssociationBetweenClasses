using System;

namespace _2_Inherritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Oject was duplicated");
        }
    }
}
