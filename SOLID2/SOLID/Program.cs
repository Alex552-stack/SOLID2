using SOLID2.SOLID.Clases;

namespace SOLID2.SOLID
{
    /*Dependency Inversion Principle
     Depend upon abstractions, not concretions
     
    Higher level modules shoul not depend upon details, details shoul depend upon higher level modules
     
    To show this i changed the Animal class to work with Interfaces(abstractions) instead of concrete classes for the sound and food.
    This allows the Animal class to work as expected and without violating any of the previous principles with any class that inherits 
    the propper interface. This could be applied in many other parts of the code but for the sake of not changing a lot from one example
    to another i only applied it in one part
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Sound sound1 = new("bark");
            Food food1 = new("meat");

            Animal dog1 = new(sound1, food1, "dog1");

            Console.WriteLine(dog1.Name + ':');
            dog1.Sound.MakeSound();
            dog1.Food.RequestFood();


            DogSound sound2 = new();
            DogFood food2 = new();

            Animal dog2 = new(sound2, food2, "dog2");
            Console.WriteLine(dog2.Name + ":");
            dog2.Sound.MakeSound();
            dog2.Food.RequestFood();
        }
    }
}