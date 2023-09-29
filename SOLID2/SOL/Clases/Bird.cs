namespace SOLID2.SOL.Clases
{
    internal class Bird : Animal
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
