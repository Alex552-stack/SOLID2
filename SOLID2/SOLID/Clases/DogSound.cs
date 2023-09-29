using SOLID2.SOLI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.SOLID.Clases
{
    internal class DogSound : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark bark bark");
        }
    }
}
