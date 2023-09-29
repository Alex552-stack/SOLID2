using SOLID2.SOL.Clases;

namespace SOLID2.SOL
{
    /*Liskov Substitution Principle
     Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it

    To show this i made a function AskAnimalsWhatTheyWant that uses objects of type Animal and i`m giving it
    the derived class that i make in the Open Closed example(Bird) and nothing changes, everything works as expected
     */
    internal class Program
    {
        static void AskAnimalsWhatTheyWant(Animal[] animals)
        {
            foreach (Animal animal in animals) 
            {
                Console.WriteLine($"{animal.Name}:");
                animal.Food.RequestFood();
            }
        }
        static void Main(string[] args)
        {
            Animal[] MyAnimals =
            {
                new Animal("Bark", "meat", "dog"),
                new Bird("Cra", "seeds", "crow")
            };
            AskAnimalsWhatTheyWant(MyAnimals);
        }
    }
}