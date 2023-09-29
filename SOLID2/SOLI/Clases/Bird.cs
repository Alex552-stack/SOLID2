using SOLID2.SOLI.Interfaces;

namespace SOLID2.SOLI.Clases
{
    internal class Bird : Animal, IBird
    {
        public Bird(string sound, string foodType, string name) : base(sound, foodType, name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("The bird is flying above your head");
        }

    }
}
