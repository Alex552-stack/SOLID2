using SOLID2.SOLI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.SOLID.Clases
{
    internal class DogFood : IFood
    {
        public void RequestFood()
        {
            Console.WriteLine("I want bones");
        }
    }
}
