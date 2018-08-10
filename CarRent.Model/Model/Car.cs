

using System.ComponentModel.DataAnnotations;

namespace CarRent.Model
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public string Colour { get; set; }

        public double Price { get; set; }

    }
}
