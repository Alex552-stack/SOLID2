namespace SOLID2.SOL.Clases
{
    internal class Food
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
