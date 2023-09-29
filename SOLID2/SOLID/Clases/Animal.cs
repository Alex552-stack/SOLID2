using SOLID2.SOLI.Interfaces;

namespace SOLID2.SOLID.Clases
{
    class Animal
    {
        public ISound Sound;
        public IFood Food;
        public readonly string Name;

        public Animal (ISound sound, IFood food, string name)
        {
            Sound = sound;
            Food = food;
            Name = name;
        }

        
    }
}
