using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.SO.Clases
{
    internal class Bird : Animal
    {
        public Bird(string sound, string foodType) : base(sound, foodType)
        {
        }

        public void Fly() //the new expansion
        {
            Console.WriteLine("The bird is flying above your head");
        }
    }
}
