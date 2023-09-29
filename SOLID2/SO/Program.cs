using SOLID2.SO.Clases;

namespace SOLID2.SO
{
    /* Open-Closed Principle
       Clases should be open for expansion but closed for modification
     
    To prove this is changed the dog class to something more generic(Animal) and i added a new class called bird that adds the new 
    ability(expansion) of flying to the animals
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new("Bark", "meat");
            Console.WriteLine("dog:");
            dog.Sound.MakeSound();
            dog.Food.RequestFood();

            Console.Write("\n\n\n");

            Bird crow = new("Cra","seeds");
            Console.WriteLine("crow:");
            crow.Sound.MakeSound();
            crow.Food.RequestFood();
            crow.Fly();
        }
    }
}