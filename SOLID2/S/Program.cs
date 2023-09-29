using SOLID2.S.Clases;

namespace SOLID2.S
{
/*Single Responsability Principle
 
 Each class shoud have only one purpose
  Sound - Making sound
  Food  - Requesting food  
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new();
            dog.Sound.MakeSound();
            dog.Food.RequestFood();
        }
    }
}