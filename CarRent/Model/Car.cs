using System.Collections.Generic;

namespace BuissnesLayer.Model
{
    public class Car
    {
        public string Brand { get; set; }

        public string CarName { get; set; }

        public string Colour { get; set; }

        //public string PublicName
        //{
        //    get { return Brand + " " + CarName; }
        //}

        public List<Car> CarList = new List<Car>();
    }
}
