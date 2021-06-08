using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1
{
    public class Hand
    {
        public List<Car> CarsList { get; set; }

        public Hand()
        {
            CarsList = new List<Car>();
        }

        public List<Car> MaxSpeed (int kmh)
        {
            List<Car> x = (from car in CarsList where car.km_h > kmh select car).ToList();
            return x;
        }

    }
}
