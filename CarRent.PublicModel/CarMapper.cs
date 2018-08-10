
namespace CarRent.PublicModel
{
    public static class CarMapper
    {
        public static CarPub ToPublicModel(Model.Car car)
        {
            return new CarPub()
            {
                Brand = car.Brand,
                CarName = car.Name,
                Colour = car.Colour,
                Price = car.Price
            };
        }
    }
}
