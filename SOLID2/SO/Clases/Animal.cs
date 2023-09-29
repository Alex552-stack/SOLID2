using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.SO.Clases
{
    internal class Animal
    {
        public Sound Sound;
        public Food Food;

        public Animal (string sound, string foodType)
        {
            Sound = new Sound (sound);
            Food = new Food (foodType);
        }
    }
}
