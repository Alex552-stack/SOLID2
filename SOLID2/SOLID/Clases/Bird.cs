using SOLID2.SOLI.Interfaces;

namespace SOLID2.SOLID.Clases
{
    internal class Bird : Animal, IBird
    {
        public Bird(ISound sound, IFood foodType, string name) : base(sound, foodType, name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("The bird is flying above your head");
        }

    }
}
