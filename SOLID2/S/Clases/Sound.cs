using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.S.Clases
{
    internal class Sound //making sound
    {
        private readonly string _sound;
        public Sound(string sound) 
        { 
            _sound = sound;
        }
        public void MakeSound()
        {
            Console.WriteLine(_sound);
        }
    }
}
