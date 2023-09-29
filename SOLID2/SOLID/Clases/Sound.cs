using SOLID2.SOLI.Interfaces;

namespace SOLID2.SOLID.Clases
{
    internal class Sound : ISound
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
