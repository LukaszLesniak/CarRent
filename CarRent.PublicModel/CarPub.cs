namespace CarRent.PublicModel
{
    public class CarPub
    {
        public string Brand { get; set; }

        public string CarName { get; set; }

        public string Colour { get; set; }
        
        public double Price { get; set; }

        public string PublicCars
        {
            get { return Brand + " " + CarName + " " + Colour + " " + Price; }
        }
       
    }
}
