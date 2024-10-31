using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListPropertiesAndMethods
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Accelerate()
        {
            Console.WriteLine($"{Brand} {Model} is accelerating!");
        }
    }
}