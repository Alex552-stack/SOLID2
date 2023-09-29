namespace SOLID2.SOL.Clases
{
    class Animal
    {
        public Sound Sound;
        public Food Food;
        public readonly string Name;

        public Animal (string sound, string foodType, string name)
        {
            Sound = new Sound (sound);
            Food = new Food (foodType);
            Name = name;
        }

        
    }
}
