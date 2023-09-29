using SOLID2.SOLI.Interfaces;

namespace SOLID2.SOLI.Clases
{
    internal class Food : IFood
    {
        private readonly string FoodType;
        public Food(string food) 
        {
            FoodType = food.ToLower();
        }

        public void RequestFood()
        {
            Console.WriteLine($"I want {FoodType}");
        }

    }
}
