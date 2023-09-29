using SOLID2.SOLI.Interfaces;

namespace SOLID2.SOLI.Clases
{
    class Animal
    {
        public ISound Sound;
        public IFood Food;
        public readonly string Name;

        public Animal (string sound, string foodType, string name)
        {
            Sound = new Sound (sound);
            Food = new Food (foodType);
            Name = name;
        }

        
    }
}
