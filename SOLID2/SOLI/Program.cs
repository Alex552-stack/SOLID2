using SOLID2.SOLI.Clases;

namespace SOLID2.SOLI
{
    internal class Program
    {
        /*Interface Segregation Principle
         Clients should not be forced to depend upon interfaces that they do not use
         
         In my oppinion this principle goes hand in hand with the Single-responsability principle, but it's taken a step forward,
         applying to Interfaces, so i made an interface that corresponds with each of the classes(exept Animal because it doesn't
         implement any new functionality)

         */
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