using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.S.Clases
{
    internal class Dog //the animal
    {
        public Sound Sound;
        public Food Food;

        public Dog ()
        {
            Sound = new Sound ("Bark");
            Food = new Food ("Meat");
        }
    }
}
