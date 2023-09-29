using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.S.Clases
{
    internal class Food //requesting food
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
