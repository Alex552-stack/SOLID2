namespace SOLID2.SO.Clases
{
    internal class Sound
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
